<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RepresentativeInfo.aspx.cs" Inherits="ECX.ECXInterface.UI.RepresentativeInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class=" content-box-large">
            <h3 class="text-center text-uppercase" style="background-color:PaleGoldenrod">Representative Information</h3>
            <asp:GridView runat="server" CssClass="table table-hover table-responsive" OnPreRender="gvRepresentative_prerender"  AutoGenerateColumns="false" AllowPaging="True" ShowHeaderWhenEmpty="True" ID="GridView1" PageSize="5" OnPageIndexChanging="GridView1_OnPageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="0px"
                ViewStateMode="Enabled" DataKeyNames="IdNo">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField HeaderText="Rep Id No">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblIdNo" Width="100px" Text='<%# Bind("IdNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Rep Name">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblRepName" Width="100px" Text='<%# Bind("Repname") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblstatus" Width="100px" Text='<%# Bind("Status") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Online Status">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblOnlineStatus" Width="100px" Text='<%# Bind("OnlineStatus") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Is Online Certified">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblIsOnlineCertified" Width="100px" Text='<%# Bind("IsOnlineCertified") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Online Certificate Expiry Date">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblOnlineCertificateExpiryDate" Width="100px" Text='<%# Bind("OnlineCertificateExpiryDate", "{0:MMM dd, yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="EAuction Status">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblAuctionStatusId" Width="100px" Text='<%# Bind("AuctionStatus") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Is EAuction Certified">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblIsAuctionCertified" Width="100px" Text='<%# Bind("IsAuctionCertified") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="EAuction Certificate Expiry Date">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lbAuctionCertificateExpiryDate" Width="100px" Text='<%# Bind("AuctionCertificateExpiryDate", "{0:MMM dd, yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton Text="Details" CssClass="btn-link" runat="server" OnClick="GridView1_SelectedIndexChanged" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>No Record Available</EmptyDataTemplate>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor=" #A3B86C"   />
                <PagerStyle BackColor="#A3B86C" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
 
            </asp:GridView>

            <asp:Label ID="lblRepresentativeInfo" runat="server" />
        </div>
    </div>
</asp:Content>
