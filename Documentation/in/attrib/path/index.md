<!-- attrib template: default -->
<!-- attrib title: &#91;#path#] -->
<!-- attrib code: yeah -->
<div class="warning card">
    <b>This is an Apricot special attribute.</b> It <em>cannot</em> be defined with <code>&lt;!-- attrib path: ... --></code>.
</div>
    The path to the current page from the site's root. Can be used for conditionals.

**Example:**
*[#path#] (this page)*
<pre><code>&lt;title>&#91;path!=index.md][#title#] - [/path!=]AutoSite Documentation&lt;/title>
...
&#91;path=index.md]You are on the homepage.[/path=]
&#91;path!=index.md]You are not on the homepage.[/path!=]</code></pre>
**Output:**
> **Page title:** [path!=index.md][#title#] - [/path!=]AutoSite Documentation
>
> [path=index.md]You are on the homepage.[/path=]
> [path!=index.md]You are not on the homepage.[/path!=]

Test