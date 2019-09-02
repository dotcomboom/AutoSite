# AutoSite XL

AutoSite XL is an all-in-one static site generator program. It's been rebuilt from the ground up, with third party components here and there, to either supplement or completely replace the original AutoSite.

At its core, AutoSite XL and its primary build engine, **Apricot** is simple to work with. It's 99% backwards-compatible with the Python-based AutoSite and uses **CommonMark**.NET to aid page drafting. For what's not backwards-compatible (plugins) a compiled EXE of the Python 3-based engine can also be used.

AutoSite XL's user interface is designed with flexibility in mind: any of the available panels can be shown or hidden at will, and the built in editor uses **FastColoredTextBox** which includes HTML syntax highlighting.

## Site Structure

An AutoSite XL site is divided into three sections: **Pages**, which are stored in the `in` folder, **Templates**, which are stored into the `templates` folder, and **Includes**, which are stored in the `includes` folder. Additionally, the output site goes into the `out` folder. Pages, Templates, and Includes all can be accessed by the **Explorer** tree.

If you're starting a new site from scratch, no problem; just create a folder for it and AutoSite XL will create these above folders automagically.

## Building your Site

Building is done either from the **Apricot Output** panel, shown by default, or the **Build** menu on the top. There are two build engines available: **Apricot**, which is built into AutoSite XL and powers some of its special features, or **Python 3 AutoSite**, which allows you to use [regular AutoSite](https://github.com/dotcomboom/AutoSite) for compatibility. There are very little differences between the two at this point, with the exception of the plugin support in the original and a different form of Markdown (CommonMark) being used.

If you do need to use the regular AutoSite, you will need a compiled EXE which you can get [at the AutoSite releases on Github](https://github.com/dotcomboom/AutoSite/releases). These are made with pyinstaller.

## Templates and Attributes

Templates are full HTML pages where attributes are placed on areas that will be replaced by text from a page that uses the template. 

Baked in are the special attributes `root`, relative path to root, `path`, the relative path of the file, `template`, used primarily to tell Apricot what template file to use, and most importantly `content`, which is how you get the page's contents into the template. However, from there you can create in essence an unlimited amount of attributes. Common ones are for titles, subtitles, descriptions, and defining which, say, CSS file to use; the sky's really the limit.

Attributes within pages are defined like this at the top of the document:
```<!-- attrib title: New Page Title -->```
In this example, any reference of `[#title#]` will be replaced with `New Page Title` within the template. If an attribute isn't present in the page, the tag is left the same in the template.

When you build your site, AutoSite XL's new **Attribute Map** located in the **Apricot Output** panel allows you to get a birds' eye view of all the attributes your site uses, their values, and what pages have those values. It's great for identifying errors, or just seeing what pages use which templates for example.

![AutoSite XL](https://github.com/dotcomboom/AutoSite-XL/blob/master/screenshot_xp.png?raw=true)

## Conditionals

A namesake feature of AutoSite has always been conditional text, which also returns in Apricot. Within your template, you can define some text in a line to only show if an attribute has a certain value. For example, you can have a link only show if the page's `path` is `index.md` (from the perspective of AutoSite processing the page).

```html
[path=index.md]<a href="[#root#]page2.html">Proceed</a>[/path=]
```

Or, on the contrary, you can have a link only show if the page's path is *not* index.md with the `!=` inequality.

```html
[path!=index.md]<a href="[#root#]index.html">Return to Index</a>[/path!=]
```

A slightly more advanced example, which doesn't link Home if you're already on `index.md` (Markdown files are rendered out to `.html` files of the same name):

```html
[path!=index.md]<a href="[#root#]index.html">[/path!=]
   Home
[path!=index.md]</a>[/path!=]
```

It's important to note that while conditionals are most *commonly* used with the `path` attribute

*The start and end of conditionals must be on the same line.*

## Includes

**Includes** is where files Apricot should *not* touch should go, like images, stylesheets and other static files. These can be easily linked to from the template via the aforementioned `root` special attribute. Just plop `[#root#]` down and then the relative path to the file from there:

```html
<link rel="stylesheet" href="[#root#]games/style.css" type="text/css">
```

No matter where the page is located, Apricot will find the relative path to root so you can access these files. 

## Previews

The **Preview** panel contains a web browser that's primarily used for seeing how your general markup or Markdown will look in pages before they're slotted into a template. In the **Apricot Output** panel there are two buttons to view your built site: one uses the built in preview, and the other opens the site in your default browser, provided that there's an `index.html` file present in the output.

The built-in web browser uses Winforms' WebBrowser control, which in turn uses Internet Explorer in compatibility mode by default. While the latest version of Internet Explorer on your computer isn't used, it's possible to change that with [a registry hack](https://wiki.imacros.net/IE9_Nags#What_IE_compatibility_mode_does_the_webbrowser_control_use.3F): just use the name `AutoSite XL.exe` instead of `iMacros.exe`. I haven't tried it myself, so take caution.

## Nitty-gritty stuff

### System Requirements

AutoSite XL (w/Apricot) only requires the **.NET Framework 2.0** and has been tested on hardware as meager as the **150mhz Pentium MMX and 32 megabytes of RAM**. While the RTM release of .NET Framework 2.0 that runs on Windows 98 is a little quirky (the icon theme needs to be loaded manually, and I've noticed some protected memory errors) it's safe to assume that your computer will run AutoSite XL. I'm saddened to say, however, that it will not run on a toaster.

The pre-compiled Python-based AutoSite engine should run on any 64-bit PC that meets the system requirements of Python 3.7 and pyinstaller's output. And if you don't run Windows at all, [the Python-based CLI AutoSite](https://github.com/dotcomboom/AutoSite) is still a good option and will behave very similarly to Apricot. Unfortunately, I haven't been able to get AutoSite XL running on Mono for macOS as of yet.

### Build Requirements

AutoSite XL is made with **Visual Basic 2008 Express Edition** to target **.NET Framework 2.0**. If you're contributing, it'd be great to use that version but not strictly necessary if you're only pushing changes to the `.vb` files. You will need the DLLs for **[FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox)** and [**CommonMark.NET**](https://github.com/Knagis/CommonMark.NET), which are included in the release builds.

#### Why .NET Framework 2.0? Why Winforms? *Why Visual Basic 2008 Express Edition?*

Choosing such an early version of the framework and Visual Studio was a strategic decision. 

**.NET Framework:** .NET Framework 2.0 is the version with the largest reach, supporting 98 all the way through 10. It also gives me something to point out on the back of the box, so that's that. If need be, most if not all my code will also work on the latest version of the framework if I needed to target it.

**Winforms:** While if I could have went with WPF or even UWP for the interface of AutoSite XL, that would have made sacrifices on compatibility with older systems, and possibly also have impacted file sizes. WPF doesn't necessarily look native out of the box without modification, and the designer isn't necessarily the lightest either. Primarily though it's just not what I'm experienced with.

**VB.NET**: I decided to stick to a language I was familar with for this project, and there really aren't many downsides aside from being less common, at least for now. Both languages are very similar as they use the same framework, and you can even convert between the two. And I've also mentioned that I can rework it into a C# application in case support is dropped later down the line.

**Visual Basic 2008 Express**: In fact, I started working on the interface for AutoSite XL with Visual Studio 2017 Community. However, rather quickly I noticed how darn *slow* the Winforms designer got as more controls were added. Additionally it only would've gotten worse within a virtual machine on my laptop, so I decided to use an older version, which went a lot smoother and worked on earlier versions of Windows (XP+).

All of these factors with the exception of porting over from Winforms can be very easily changed. If need be, you can open the `.vbproj` file in Visual Studio 2017 to migrate it, and go into `My Project` to change the framework to the absolute latest version. And there are tools from [Telerik](http://converter.telerik.com) and other places that allow you to convert VB.NET code to C# and back again, which were very useful during development.

## FAQ that actually haven't hit my inbox once yet

### Does Apricot evaluate/execute any code within pages?

With the exception of aforementioned **conditionals** and **attributes**, no. PHP files, for example, rendered out with Apricot will still be PHP files to be executed server-side.

### Is there plugin support?

Not yet- if you rely on Python-based AutoSite plugins, the Python build engine is still available, but these won't be displayed in the tree.

### Does AutoSite XL serve any pages?

Nope: it exports them to an output folder. You can then upload them to a server of your choosing. That is what static sites are about, ay?

## Credits

I'd like to thank:

- **The developers of [FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox) and [CommonMark.NET](https://github.com/Knagis/CommonMark.NET)** for their great libraries
- **mariteaux** for his original AutoSite logo, original [guide](https://dotcomboom.somnolescent.net/autosite/guide/), and for using AutoSite from really the beginning and **everybody in [Somnolescent](https://somnolescent.net/) too** for giving feedback and supporting development
- **Answers on StackOverflow and elsewhere** for when I really just needed to Googl- Bing something for the answer (it happens to the best of us)

## License

AutoSite XL's code *with the exception* of the libraries used, and the code used from StackOverflow and other websites (referenced as needed in the source) is licensed under the MIT License.
