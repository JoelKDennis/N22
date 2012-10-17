<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.ascx.cs" Inherits="North22ndStreet.Web.MainMenu" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<telerik:RadMenu ID="RadMenu1" Runat="server" Skin="Sunset" Width="884px" 
    BorderColor="#B9321D" BorderStyle="Solid" BorderWidth="1px" 
    style="top: 0px; left: 0px" >
<Items>
    <telerik:RadMenuItem Text="HOME" Width="100px" NavigateUrl="~/Default.aspx" ></telerik:RadMenuItem>
    <telerik:RadMenuItem Text="BUSINESSES" Width="100px" NavigateUrl="~/MerchantSearch.aspx"></telerik:RadMenuItem>
    <telerik:RadMenuItem Text="NEWS" Width="100px" NavigateUrl="~/AW/default.aspx"></telerik:RadMenuItem>
    <telerik:RadMenuItem Text="EVENTS" Width="100px">
        <Items>
            <telerik:RadMenuItem Text="AWF Family Fun 2010" Width="200px" NavigateUrl="AWF2010Festival.aspx"></telerik:RadMenuItem>
            <telerik:RadMenuItem Text="22nd Street FAM DAY 2010" Width="200px" NavigateUrl="FAMDAY2010.aspx"></telerik:RadMenuItem>
            <telerik:RadMenuItem Text="EVENT MAP" Width="200px" NavigateUrl="EventMap2010.aspx"></telerik:RadMenuItem>            
        </Items>
    </telerik:RadMenuItem>    
    <telerik:RadMenuItem Text="DIRECTIONS" Width="100px" NavigateUrl="~/Directions.aspx"></telerik:RadMenuItem>
    <telerik:RadMenuItem Text="REAL ESTATE" Width="100px" NavigateUrl="~/RealEstate.aspx"></telerik:RadMenuItem>
    <telerik:RadMenuItem Text="HISTORY" Width="100px" NavigateUrl="~/AW/History.aspx"></telerik:RadMenuItem>
</Items>
<CollapseAnimation Type="OutQuint" Duration="200"></CollapseAnimation>
</telerik:RadMenu>