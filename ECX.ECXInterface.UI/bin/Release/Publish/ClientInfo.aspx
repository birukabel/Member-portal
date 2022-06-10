<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientInfo.aspx.cs" Inherits="ECX.ECXInterface.UI.ClientInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="content-box-large">
            <h3 class="text-center text-uppercase" style="background-color: PaleGoldenrod">Client Information</h3>
            <br />
            <div class="col-md-offset-8">
                <div class=" wrap-search validate-input m-b-11">
                    <asp:TextBox type="text" id="txtSearch" runat="server" class="search" pattern="([C]).([0-9]).{3,8}"
                        title="Must start with upper case letter C followed by more than 4 digit numbers.." required="required" placeholder="Search your client by  ID here..." OnTextChanged="txtSearch_TextChanged"  />
                    <span class="focus-search"></span>
                    <span class="symbol-search">
                        <i class="fa fa-search"></i>
                    </span>
                    <span></span>

                </div>
            </div>
             <asp:Label ID="lblNoDataFound" runat="server" />
            <asp:GridView ID="gvClientInfo" runat="server" AutoGenerateRows="False" EnableModelValidation="false" CssClass="table table-hover table-responsive record" AutoGenerateColumns="False" AllowPaging="true" OnPreRender="gvClientInfo_prerender" PageSize="10" OnPageIndexChanging="gvClientInfo_PageIndexChanging" DataKeyNames="ClientId" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="0px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField HeaderText="Client Id">
                        <ItemTemplate>
                            <asp:Label ID="lblClientIdNo" runat="server" Text='<%# Bind("IDNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IsActive?">
                        <ItemTemplate>
                            <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Active") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Member Client Type">
                        <ItemTemplate>
                            <asp:Label ID="lblMemberClientType" runat="server" Text='<%# Bind("MemberClientType") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Client Type">
                        <ItemTemplate>
                            <asp:Label ID="lblClientType" runat="server" Text='<%# Bind("ClientTypeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Commodity Name">
                        <ItemTemplate>
                            <asp:Label ID="lblCommidityName" runat="server" Text='<%# Bind("CommodityName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Created Date" DataFormatString="{0:MMM/dd/yyyy}" DataField="CreatedDate" />
                    <asp:TemplateField HeaderText="Is STP?">
                        <ItemTemplate>
                            <asp:Label ID="lblIsStp" runat="server" Text='<%# Bind("IsSTP") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton Text="Details" runat="server" CssClass="btn btn-link" OnClick="gvClientInfo_SelectedIndexChanged" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor=" #A3B86C" />
                <PagerStyle BackColor="#A3B86C" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />

            </asp:GridView>
            <asp:Label ID="lbClientInfo" runat="server" />
            </> 
       
        </div>
    </div>
</asp:Content>
