<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"  CodeBehind="Default.aspx.cs" Inherits="ECX.ECXInterface.UI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="content-box-large">
            <div class="panel-heading">
                <div class="form-group">
                    <h3 class="text-center text-uppercase panel-title" style="background-color:PaleGoldenrod">Member Information</h3>
                    <div class="panel-body" style="background-color:LightGoldenrodYellow">
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Member Id </em>:
                        <asp:Label ID="lblMemberId" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Organization Name</em> :
                        <asp:Label ID="lblOrganizationName" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Status</em> :
                        <asp:Label ID="lblStatus" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Member Class Name</em> :
                        <asp:Label ID="lblMemberClassName" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Classification Name</em> :
                        <asp:Label ID="lblClassificationName" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Organization Type Name</em> :
                        <asp:Label ID="lblOrganizationTypeName" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Member Client Type</em> :
                        <asp:Label ID="lblMemberClientType" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>VAT Number</em> :
                        <asp:Label ID="lblVatNumber" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>TIN Number</em> :
                        <asp:Label ID="lblTinNumber" runat="server" CssClass="font-weight-bold" />
                        </div>


                      <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>VAT Exemption</em> :
                        <asp:Label ID="lblVATexemption" runat="server" CssClass="font-weight-bold" />
                        </div>


                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>TOT Exemption</em> :
                        <asp:Label ID="Label1" runat="server" CssClass="font-weight-bold" />
                        </div>

<%--                          <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Withholding Exemption</em> :
                        <asp:Label ID="lblWithholdingexemption" runat="server" CssClass="font-weight-bold" />
                        </div>--%>

                       <div class="col-md-4 col-sm-6 col-xs-12">
                            <em>Is NMDTs</em> :
                        <asp:Label ID="lblMemberType" runat="server" CssClass="font-weight-bold" />
                        </div>
                        <asp:Label ID="lblError" runat="server" Text="market for all!" ForeColor="white"  />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-md-12  ">
        <div class="content-box-large">
            <h3 class="text-center text-uppercase" style="background-color:PaleGoldenrod">Licence Information</h3>

            <asp:GridView ID="gvMemberLicence" runat="server" AutoGenerateColumns="False" CssClass="table table-responsive-lg " CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="0px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="True" SortExpression="BusinessLicenceId" />
                    <asp:BoundField DataField="ExpirationDate" DataFormatString="{0:MMM dd, yyyy}" HeaderText="Expiration Date" SortExpression="ExpirationDate" />
                    <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor=" #A3B86C" />
                <PagerStyle BackColor="#A3B86C" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            </asp:GridView>
            <asp:Label ID="Label10" runat="server" />
        </div>

    </div>

</asp:Content>
