<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DefaultError.aspx.cs" Inherits="ECX.ECXInterface.UI.DefaultError" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="content-box-large">
            <h2 class="text-center" style="color: red">Error!</h2>
            <p>
               <asp:label ID="lblError" runat="server" ><b></b></asp:label>
            </p>
            <small>If you need further assistance, please contact our help desk at <a href="mailto:itdevelopment@ecx.com.et">ItDevelopment@ecx.com.et</a></small>
        </div>
    </div>
</asp:Content>
