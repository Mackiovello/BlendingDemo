// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "MasterPage.json"
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
using __MasterPa__ = global::CollectionLister.MasterPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MaSchema__ = global::CollectionLister.MasterPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __MasterPa1__ = global::CollectionLister.MasterPage.JsonByExample;
using __MasterPa2__ = global::CollectionLister.MasterPage.Input;
using __MaHtml__ = global::CollectionLister.MasterPage.Input.Html;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class MasterPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MasterPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MasterPage(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__MasterPa__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/CollectionLister/views/MasterPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__MasterPa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MasterPa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CurrentPage = Add<__TObject__>("CurrentPage");
                CurrentPage.SetCustomAccessors((_p_) => { return ((__MasterPa__)_p_).__bf__CurrentPage__; }, (_p_, _v_) => { ((__MasterPa__)_p_).__bf__CurrentPage__ = (__Json__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __MasterPa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TObject__ CurrentPage;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "MasterPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "MasterPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__CurrentPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ CurrentPage {
    #line 3 "MasterPage.json"
        get {
        #line hidden
            return (__Json__)Template.CurrentPage.Getter(this); }
        #line 3 "MasterPage.json"
        set {
        #line hidden
            Template.CurrentPage.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MasterPa__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MasterPage_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
