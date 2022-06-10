<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientDetails.aspx.cs" Inherits="ECX.ECXInterface.UI.ClientDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-12">
        <div class="content-box-large">
            <h2 style="background-color: PaleGoldenrod">Client Detail Information</h2>
            <div class="panel-body" style="background-color: LightGoldenrodYellow">
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>ClientId</em> :
                        <asp:Label ID="lblClientId" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Organziation Name</em> :
                        <asp:Label ID="lblOrganizationName" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Full Name</em> :
                        <asp:Label ID="lblFullName" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Phone Number</em> :
                <asp:Label ID="lblPhoneNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Client Type</em> :
                        <asp:Label ID="lblClientType" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Company Type</em> :
                        <asp:Label ID="lblCompanyType" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Status</em> :
                        <asp:Label ID="lblStatus" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Tin Number</em> :
                        <asp:Label ID="lblTinNo" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Vat Number</em> :
                        <asp:Label ID="lblVatNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Vat Registration Date</em> :
                        <asp:Label ID="lblVatRegistrationDate" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Vat Exempt</em> :
                        <asp:CheckBox ID="cbVatExempt" runat="server" Enabled="false" CssClass="font-weight-bold" />
                        <span><p class="">If Checks You are  vat Exempt</p></span>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Tot Exempt</em> :
                        <asp:CheckBox ID="cbTotExempt" runat="server" Enabled="false" CssClass="font-weight-bold" />
                        <span><p>If Checks You are  tot Exempt</p></span>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>With Holding Exempt</em> :
                        <asp:CheckBox ID="cbWithholdingExempt" runat="server" Enabled="false" CssClass="font-weight-bold" />
                        <span><p class="">If Checks You  are with holidng Exempt</p></span>
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Organization Type</em> :
                        <asp:Label ID="lblOrganizationType" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Client Type Name</em> :
                        <asp:Label ID="lblClientTypeName" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <b>Is Online Trained</b> :
                        <asp:Label ID="lblIsOnlineTrained" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <asp:Label ID="lblOTEDDisplay" runat="server" /><asp:Label ID="lblOTED" runat="server" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <asp:Label ID="lblOTDDisplay" runat="server" /><asp:Label ID="lblOTD" runat="server" />
                </div>
                <asp:Label runat="server" Text="." ForeColor ="White"/> 
                
            </div>
        </div>
    </div>
    <div class="col-md-12 ">
        <div class="content-box-large">
            <h2 style="background-color: PaleGoldenrod">Client Business Licence</h2>
            <asp:GridView ID="gvClientBusinessLicence" runat="server" AutoGenerateColumns="False" CssClass="table table-responsive" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="0px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <%--<asp:BoundField DataField="BussinessLicenceId" HeaderText="Business Licence Id" ReadOnly="True" SortExpression="BusinessLicenceId" />--%>
                    <asp:BoundField DataField="Name" HeaderText="Commodity Name" ReadOnly="True" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="True" SortExpression="Description" />
                    <asp:BoundField DataField="ExpirationDate" DataFormatString="{0:MMM dd, yyyy}" HeaderText="Expiration Date" SortExpression="ExpirationDate" />
                    <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                   
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor=" #A3B86C" />
                <PagerStyle BackColor="#A3B86C" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            </asp:GridView>
            <a href='javascript:history.go(-1)' Class="btn btn-lg btn-outline-success  col-md-offset-5 " >Back</a>
               
            <%--<asp:Button ID="Button2" runat="server" OnClick="btnHomePage_Click" Text="Back" CssClass="btn   btn-lg btn-outline-success  col-md-offset-5 " />--%>
        </div>
    </div>

</asp:Content>
