﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("AutoSite.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend ReadOnly Property __() As String
            Get
                Return ResourceManager.GetString("__", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property autosite_32() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("autosite_32", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Browse() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Browse", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Build() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Build", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Copy() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Copy", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Cut() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Cut", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-style.
        '''</summary>
        Friend ReadOnly Property Defaults_NewCss() As String
            Get
                Return ResourceManager.GetString("Defaults_NewCss", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-file.
        '''</summary>
        Friend ReadOnly Property Defaults_NewFile() As String
            Get
                Return ResourceManager.GetString("Defaults_NewFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-page.
        '''</summary>
        Friend ReadOnly Property Defaults_NewHtml() As String
            Get
                Return ResourceManager.GetString("Defaults_NewHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html lang=&quot;en&quot;&gt;
        '''  &lt;head&gt;
        '''    &lt;title&gt;New HTML Page&lt;/title&gt;
        '''    &lt;meta charset=&quot;utf-8&quot;&gt;
        '''  &lt;/head&gt;
        '''  &lt;body&gt;
        '''    &lt;h1&gt;New HTML Page&lt;/h1&gt;
        '''  &lt;/body&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Friend ReadOnly Property Defaults_NewHtmlInclude_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewHtmlInclude_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- attrib template: default --&gt;
        '''&lt;!-- attrib title: New HTML Page --&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property Defaults_NewHtmlPage_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewHtmlPage_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html lang=&quot;en&quot;&gt;
        '''  &lt;head&gt;
        '''    &lt;title&gt;[#title#]&lt;/title&gt;
        '''    &lt;meta charset=&quot;utf-8&quot;&gt;
        '''  &lt;/head&gt;
        '''  &lt;body&gt;
        '''    &lt;h1&gt;[#title#]&lt;/h1&gt;
        '''    [#content#]
        '''  &lt;/body&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Friend ReadOnly Property Defaults_NewHtmlTemplate_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewHtmlTemplate_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-script.
        '''</summary>
        Friend ReadOnly Property Defaults_NewJs() As String
            Get
                Return ResourceManager.GetString("Defaults_NewJs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-page.
        '''</summary>
        Friend ReadOnly Property Defaults_NewMd() As String
            Get
                Return ResourceManager.GetString("Defaults_NewMd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- attrib template: default --&gt;
        '''&lt;!-- attrib title: New Markdown Page --&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property Defaults_NewMdPage_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewMdPage_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to new-page.
        '''</summary>
        Friend ReadOnly Property Defaults_NewPhp() As String
            Get
                Return ResourceManager.GetString("Defaults_NewPhp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?php
        '''      echo &quot;This will be interpreted by the server. Hello universe!&quot;;
        '''?&gt;.
        '''</summary>
        Friend ReadOnly Property Defaults_NewPhpOther_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewPhpOther_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- attrib template: default --&gt;
        '''&lt;!-- attrib title: New PHP Page --&gt;
        '''&lt;?php
        '''      echo &quot;This will be interpreted by the server. Hello universe!&quot;;
        '''?&gt;.
        '''</summary>
        Friend ReadOnly Property Defaults_NewPhpPage_Contents() As String
            Get
                Return ResourceManager.GetString("Defaults_NewPhpPage_Contents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Apricot returned this exception:
        '''
        '''{0}.
        '''</summary>
        Friend ReadOnly Property Error_BuildFailed() As String
            Get
                Return ResourceManager.GetString("Error_BuildFailed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build failed.
        '''</summary>
        Friend ReadOnly Property Error_BuildFailed_Title() As String
            Get
                Return ResourceManager.GetString("Error_BuildFailed_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build the site first to view output..
        '''</summary>
        Friend ReadOnly Property Error_BuildToViewOutput() As String
            Get
                Return ResourceManager.GetString("Error_BuildToViewOutput", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The file could not be saved..
        '''</summary>
        Friend ReadOnly Property Error_CouldNotSaveFile() As String
            Get
                Return ResourceManager.GetString("Error_CouldNotSaveFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Something went wrong when trying to save the log:
        '''
        '''{0}.
        '''</summary>
        Friend ReadOnly Property Error_LogSaveFail() As String
            Get
                Return ResourceManager.GetString("Error_LogSaveFail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to save.
        '''</summary>
        Friend ReadOnly Property Error_LogSaveFail_Title() As String
            Get
                Return ResourceManager.GetString("Error_LogSaveFail_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to AutoSite could not rename the in\ folder to pages\. Please rename the folder manually and open your site again..
        '''</summary>
        Friend ReadOnly Property Error_UpgradeFail() As String
            Get
                Return ResourceManager.GetString("Error_UpgradeFail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to convert.
        '''</summary>
        Friend ReadOnly Property Error_UpgradeFail_Title() As String
            Get
                Return ResourceManager.GetString("Error_UpgradeFail_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Includes.
        '''</summary>
        Friend ReadOnly Property Explorer_Includes() As String
            Get
                Return ResourceManager.GetString("Explorer_Includes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pages.
        '''</summary>
        Friend ReadOnly Property Explorer_Pages() As String
            Get
                Return ResourceManager.GetString("Explorer_Pages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Templates.
        '''</summary>
        Friend ReadOnly Property Explorer_Templates() As String
            Get
                Return ResourceManager.GetString("Explorer_Templates", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Folder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Folder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property GotoRow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("GotoRow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Include() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Include", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property InsertPanel() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("InsertPanel", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property NewSite() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NewSite", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property OpenFolder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("OpenFolder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Page() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Page", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Paste() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Paste", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property PreviewWebTab() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("PreviewWebTab", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Changes will be applied on restart..
        '''</summary>
        Friend ReadOnly Property Prompt_ChangesOnRestart() As String
            Get
                Return ResourceManager.GetString("Prompt_ChangesOnRestart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to AutoSite will create a site in the folder located at {0}. Is this OK?.
        '''</summary>
        Friend ReadOnly Property Prompt_CreateSite() As String
            Get
                Return ResourceManager.GetString("Prompt_CreateSite", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to AutoSite now uses the pages\ path for the Pages folder. Compatibility with older releases of AutoSite will be affected by this conversion..
        '''</summary>
        Friend ReadOnly Property Prompt_ProjectUpgrade() As String
            Get
                Return ResourceManager.GetString("Prompt_ProjectUpgrade", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Update Site.
        '''</summary>
        Friend ReadOnly Property Prompt_ProjectUpgrade_Title() As String
            Get
                Return ResourceManager.GetString("Prompt_ProjectUpgrade_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A sanitary build will move the output folder to the Recycle Bin before building, removing any stray files..
        '''</summary>
        Friend ReadOnly Property Prompt_SanitaryBuild() As String
            Get
                Return ResourceManager.GetString("Prompt_SanitaryBuild", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save changes to {0}?.
        '''</summary>
        Friend ReadOnly Property Prompt_SaveChangesToFile() As String
            Get
                Return ResourceManager.GetString("Prompt_SaveChangesToFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Some files have unsaved changes. Save them?.
        '''</summary>
        Friend ReadOnly Property Prompt_SaveFilesBeforeClosing() As String
            Get
                Return ResourceManager.GetString("Prompt_SaveFilesBeforeClosing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The site located in {0} could not be opened. Do you want to remove it from the Recent Sites list?.
        '''</summary>
        Friend ReadOnly Property Question_RemoveFromRecents() As String
            Get
                Return ResourceManager.GetString("Question_RemoveFromRecents", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Example: {0}.
        '''</summary>
        Friend ReadOnly Property QuickInsert__Example() As String
            Get
                Return ResourceManager.GetString("QuickInsert__Example", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Output: {0}.
        '''</summary>
        Friend ReadOnly Property QuickInsert__Output() As String
            Get
                Return ResourceManager.GetString("QuickInsert__Output", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build for more options.
        '''</summary>
        Friend ReadOnly Property QuickInsert_Build() As String
            Get
                Return ResourceManager.GetString("QuickInsert_Build", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build.
        '''</summary>
        Friend ReadOnly Property QuickInsert_Build_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_Build_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to AutoSite can give you more suggestions when you build
        '''your site and populate the Attribute Map..
        '''</summary>
        Friend ReadOnly Property QuickInsert_Build_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_Build_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Content.
        '''</summary>
        Friend ReadOnly Property QuickInsert_content_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_content_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Outputs the page&apos;s content.
        '''
        '''Use once in templates..
        '''</summary>
        Friend ReadOnly Property QuickInsert_content_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_content_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Define {0}.
        '''</summary>
        Friend ReadOnly Property QuickInsert_DefineGeneric_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_DefineGeneric_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Defines the {0} attribute for this page..
        '''</summary>
        Friend ReadOnly Property QuickInsert_DefineGeneric_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_DefineGeneric_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Define a new attribute.
        '''</summary>
        Friend ReadOnly Property QuickInsert_DefineNew_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_DefineNew_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Adds an attribute definition..
        '''</summary>
        Friend ReadOnly Property QuickInsert_DefineNew_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_DefineNew_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Defines the template used by the current page.
        '''
        '''Default is {0}, which tells AutoSite to use {1} in the templates folder..
        '''</summary>
        Friend ReadOnly Property QuickInsert_DefineTemplate_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_DefineTemplate_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Outputs the page&apos;s value for the {0} attribute..
        '''</summary>
        Friend ReadOnly Property QuickInsert_Generic_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_Generic_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Insert conditional.
        '''</summary>
        Friend ReadOnly Property QuickInsert_InsertConditional_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_InsertConditional_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open the Insert Conditional dialog.
        '''
        '''Conditionals allow you to output text if an attribute has a certain value..
        '''</summary>
        Friend ReadOnly Property QuickInsert_InsertConditional_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_InsertConditional_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Last modified date.
        '''</summary>
        Friend ReadOnly Property QuickInsert_modified_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_modified_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Outputs the date the page was last modified on..
        '''</summary>
        Friend ReadOnly Property QuickInsert_modified_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_modified_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Path.
        '''</summary>
        Friend ReadOnly Property QuickInsert_path_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_path_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Outputs the page&apos;s relative path from root..
        '''</summary>
        Friend ReadOnly Property QuickInsert_path_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_path_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Relative path to root.
        '''</summary>
        Friend ReadOnly Property QuickInsert_root_Tip() As String
            Get
                Return ResourceManager.GetString("QuickInsert_root_Tip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Outputs the relative path from the page to the site root.
        '''
        '''Use this to begin paths to stylesheets, images, and other 
        '''pages..
        '''</summary>
        Friend ReadOnly Property QuickInsert_root_TipText() As String
            Get
                Return ResourceManager.GetString("QuickInsert_root_TipText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Redo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Redo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ReplaceAll() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ReplaceAll", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property SanitaryBuild() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SanitaryBuild", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Save() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Save", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property SaveAll() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SaveAll", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Search() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Search", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Tag() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Tag", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Template() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Template", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add files to {0}.
        '''</summary>
        Friend ReadOnly Property UI_AddFilesDialog_Title() As String
            Get
                Return ResourceManager.GetString("UI_AddFilesDialog_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to View.
        '''</summary>
        Friend ReadOnly Property UI_Editor_ViewFile() As String
            Get
                Return ResourceManager.GetString("UI_Editor_ViewFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open.
        '''</summary>
        Friend ReadOnly Property UI_Open() As String
            Get
                Return ResourceManager.GetString("UI_Open", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open file location.
        '''</summary>
        Friend ReadOnly Property UI_OpenFileLocation() As String
            Get
                Return ResourceManager.GetString("UI_OpenFileLocation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open folder location.
        '''</summary>
        Friend ReadOnly Property UI_OpenFolderLocation() As String
            Get
                Return ResourceManager.GetString("UI_OpenFolderLocation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open with default program.
        '''</summary>
        Friend ReadOnly Property UI_OpenWithDefault() As String
            Get
                Return ResourceManager.GetString("UI_OpenWithDefault", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Start Page.
        '''</summary>
        Friend ReadOnly Property UI_StartPage_Title() As String
            Get
                Return ResourceManager.GetString("UI_StartPage_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Undo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Undo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Value() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Value", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Web() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Web", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WebTest() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WebTest", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property XP_Folder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("XP_Folder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property XP_Include() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("XP_Include", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property XP_Page() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("XP_Page", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property XP_Template() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("XP_Template", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
