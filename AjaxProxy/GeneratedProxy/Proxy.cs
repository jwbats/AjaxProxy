﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IXDomainService", Namespace="http://tempuri.org/")]
public partial class XDomainService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback DoWork1OperationCompleted;
    
    /// <remarks/>
    public XDomainService() {
        this.Url = "http://localhost:64140/XDomainService.svc";
    }
    
    /// <remarks/>
    public event DoWork1CompletedEventHandler DoWork1Completed;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IXDomainService/DoWork1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string DoWork1([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string json) {
        object[] results = this.Invoke("DoWork1", new object[] {
                    json});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginDoWork1(string json, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("DoWork1", new object[] {
                    json}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndDoWork1(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void DoWork1Async(string json) {
        this.DoWork1Async(json, null);
    }
    
    /// <remarks/>
    public void DoWork1Async(string json, object userState) {
        if ((this.DoWork1OperationCompleted == null)) {
            this.DoWork1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnDoWork1OperationCompleted);
        }
        this.InvokeAsync("DoWork1", new object[] {
                    json}, this.DoWork1OperationCompleted, userState);
    }
    
    private void OnDoWork1OperationCompleted(object arg) {
        if ((this.DoWork1Completed != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.DoWork1Completed(this, new DoWork1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
public delegate void DoWork1CompletedEventHandler(object sender, DoWork1CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DoWork1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal DoWork1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
