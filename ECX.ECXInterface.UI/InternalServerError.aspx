<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InternalServerError.aspx.cs" Inherits="ECX.ECXInterface.UI.InternalServerError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="content-box-large">
            <h2 class="text-center" style="color:red">Internal Server Error, Please try again...</h2>
            <p>
                <b>An unknown error had occured. We are aware of it and the IT team is currently working on this issue.
                Sorry for the inconvinience caused.
                </b>
            </p>
            <small>If you need further assistance, please contact our help desk at <a href="mailto:itdevelopment@ecx.com.et">ItDevelopment@ecx.com.et</a></small>
       
        </div>
    </div>
</asp:Content>
