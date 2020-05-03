<!-- attrib template: default -->
<!-- attrib title: &#91;#root#] -->
<!-- attrib code: yeah -->
<div class="warning card">
    <b>This is an Apricot special attribute.</b> It <em>cannot</em> be defined with <code>&lt;!-- attrib root: ... --></code>. <code>&#91;#root#]</code> does not show in the Attribute Map.
</div>
    Relative path to the site's root. Used for linking to includes and other pages.

**Example:**
*[#path#] (this page)*
<pre><code>&lt;img src="&#91;#root#]img/lynx.jpg" alt="Lynx lynx" height="350"&gt;
  (or, in Markdown, the rendered equivalent of:)
!&#91;Lynx lynx&#93;(&#91;#root#]img/lynx.jpg)</code></pre>
*Output:*
> ```
> <img src="[#root#]img/lynx.jpg" alt="Lynx lynx" height="350">
>   (or, in Markdown, the rendered equivalent of:)
> ![Lynx lynx]([#root#]img/lynx.jpg)
> ```
> <img src="[#root#]img/lynx.jpg" alt="Lynx lynx" height="350">