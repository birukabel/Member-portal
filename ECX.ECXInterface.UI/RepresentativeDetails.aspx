<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RepresentativeDetails.aspx.cs" Inherits="ECX.ECXInterface.UI.RepresentativeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 table-responsive">
        <div class="content-box-large">
            <h2 style="background-color: PaleGoldenrod">Representative Detail Information</h2>
            <div class="panel-body" style="background-color: LightGoldenrodYellow">
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Identification Number</em> :
                        <asp:Label ID="lblRepId" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Online Certification Number</em> :
                        <asp:Label ID="lblOCN" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Certification Number</em> :
                        <asp:Label ID="lblCertificateNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Member Name</em> :
                        <asp:Label ID="lblMemberName" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Representative Name</em> :
                        <asp:Label ID="lblRepName" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Representative Type</em> :
                        <asp:Label ID="lblRepType" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Type Description</em> :
                        <asp:Label ID="lblRepTypeDescription" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>City</em> :
                        <asp:Label ID="lblCity" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>E-mail</em> :
                        <asp:Label ID="lblEmail" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Fax</em> :
                        <asp:Label ID="lblFax" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Kebele</em> :
                        <asp:Label ID="lblKebele" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>House Number</em> :
                        <asp:Label ID="lblHouseNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Phone Number</em> :
                        <asp:Label ID="lblPhoneNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Region</em> :
                        <asp:Label ID="lblRegion" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Mobile Phone Number</em> :
                        <asp:Label ID="lblMopilePhoneNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Woreda</em> :
                        <asp:Label ID="lblWoreda" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Zone</em> :
                        <asp:Label ID="lblZone" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Office Phone Number</em> :
                        <asp:Label ID="lblOfficePhoneNumber" runat="server" CssClass="font-weight-bold" />
                </div>
               
                
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Online Certificate Expire Date</em> :
                        <asp:Label ID="lblOnlineCertificateExpireDate" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Online Certificate Expire Date 1</em> :
                        <asp:Label ID="lblOnlineCertificateExpireDate1" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Online Certificate Issue Date</em> :
                        <asp:Label ID="lblOnlineCertificateIssueDate" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Auction Certificate Issue Date</em> :
                        <asp:Label ID="lblAuctionCertificateIssueDate" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Auction Certificate Number</em> :
                        <asp:Label ID="lblAuctionCertificateNumber" runat="server" CssClass="font-weight-bold" />
                </div>
                 <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Acution Certification Expired Date</em> :
                        <asp:Label ID="lblAuctionExpireDate" runat="server" CssClass="font-weight-bold" />
                </div>
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <em>Auction Status</em> :
                        <asp:Label ID="lblOnlineStatus" runat="server" CssClass="font-weight-bold" />
                </div>
                <asp:Button ID="btnBack" runat="server" CssClass="btn btn-outline-success col-md-offset-5 col-xs-offset-2" OnClick="btnBack_Click" Text="Back" />
            </div>
        </div>
    </div>
</asp:Content>
