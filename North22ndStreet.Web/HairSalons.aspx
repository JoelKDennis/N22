<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HairSalons.aspx.cs" Inherits="North22ndStreet.Web.Merchants.HairSalons" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/Styles.css" rel="stylesheet" type="text/css" />

    <div class="TransRedWhite Hair">
    <telerik:RadRotator ID="RadRotator1" runat="server" Width="600px" RotatorType="Buttons"
     WrapFrames="true" ItemHeight="200px" ItemWidth="200px" Skin="Sunset">
        <Items>
            <telerik:RadRotatorItem ID="radLorraines" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Lorraine’s</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />2817 N. 22nd St.
                </div>
                </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radFatima" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Fatima’s</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />2821 N. 22nd St.
                </div>
                </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radLeslie" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Leslie’s</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />2825 N. 22nd St.
                </div>
                    </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radMichelle" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Michelle’s</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />2840 N. 22nd St.
                </div>
                    </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radLois" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Lois Nelson Hair Salon</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />2859 N. 22nd St.
                </div>
                    </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radNadia" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                    <span style="font-size:14px; font-weight:bold;">Nadia’s</span>
                    <br />
                    <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                    <br />	2910 N. 22nd St.
                </div>
                    </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radNene" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                   <span style="font-size:14px; font-weight:bold;">Nene</span>
                   <br />
                   <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                   <br />2960 N. 22nd St.
               </div>
               </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radWholeNew" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                   <span style="font-size:14px; font-weight:bold;">Whole New Image</span>
                   <br />
                   <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                   <br />3001 N. 22nd St.
               </div>
                   </ItemTemplate>
            </telerik:RadRotatorItem>
            <telerik:RadRotatorItem ID="radGigi" runat="server">
                <ItemTemplate>
                <div class="Rotator">
                    <br />
                   <span style="font-size:14px; font-weight:bold;">GiGi’s</span>
                   <br />
                   <img src="Images/ComingSoonHair.gif" alt="Coming soon" />
                   <br />3033 N. 22nd St.
               </div>
               </ItemTemplate>
            </telerik:RadRotatorItem>
        </Items>
    </telerik:RadRotator>
    <br /><br /><br /><br /><br /><br />
  </div>
</asp:Content>
