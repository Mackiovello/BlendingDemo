// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ListPage.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace CollectionLister {
using __ListPage__ = global::CollectionLister.ListPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __LiSchema__ = global::CollectionLister.ListPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __ListPage1__ = global::CollectionLister.ListPage.JsonByExample;
using __ListPage2__ = global::CollectionLister.ListPage.Input;
using __LiHtml__ = global::CollectionLister.ListPage.Input.Html;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class ListPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __LiSchema__ DefaultTemplate = new __LiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ListPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ListPage(__LiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __LiSchema__ Template { get { return (__LiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ListPage__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/CollectionLister/views/ListPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__ListPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ListPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ListPage__(this) { Parent = parent }; }
            public __TString__ Html;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ListPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ListPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ListPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ListPage_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
