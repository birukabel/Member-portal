<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PageNotFound.aspx.cs" Inherits="ECX.ECXInterface.UI.PageNotFound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
        <div class="content-box-large">
            <h2 class="text-center" style="color:red">Page Not Found!</h2>
            <p>You are redirecting to unknow page, please check the speling or use the proper link to access the page</p>
        </div>
    </div>
</asp:Content>
