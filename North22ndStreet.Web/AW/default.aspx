<%@ Page Title="" Language="C#" MasterPageFile="~/AW/News.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="North22ndStreet.Web.AW.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MainNewsBG bottomBorder">
    <table width="100%" class="newspage">
    <tr>
        <td style="width:25%; vertical-align:top;">
        <asp:HyperLink ID="lnkWachovia" runat="server" CssClass="Header3" Text="Wachovia Regional Foundation Sponsors Panati Town Center" NavigateUrl="~/AW/News_Wachovia.aspx"></asp:HyperLink>        
        <div style="text-align:justify;">
        <span class="Author">By AW Community News Contributor</span><br />
        The Wachovia Regional Foundation announced that it has awarded The Allegheny West Foundation 
        (AWF) $700,000 to launch its Panati Town Center initiative for the Allegheny West neighborhood. 
        AWF will undertake a five year quality of life focused initiative for the Allegheny West neighborhood.
        </div>
        <hr />
        <asp:HyperLink ID="linkElmStreet" runat="server" CssClass="Header3" Text="Elm Street Program Summary" NavigateUrl="~/AW/News_ElmStreet.aspx"></asp:HyperLink>        
        <div style="text-align:justify;">
        <span class="Author">By AW Community News Contributor</span><br />
        The Elm Street Program is designed train managers to provide assistance and resources to residential 
        areas that are in close proximity to business districts including the North 22nd Street commercial district.
        </div>
        </td>
        
        <td style="width:50%" align="center" valign="top">
        <asp:Image ID="imgCheck" runat="server" ImageUrl="~/AW/Images/community day 9.jpg" />
        <br /><span class="picCaption">Children at Community Day 2008</span><br />
        <div style="text-align:justify;">
        <asp:HyperLink ID="lnkAWMainStreet" runat="server" CssClass="Header4" Text="Allegheny West Main Street Report" NavigateUrl="~/AW/News_AWMainStreetReport2008.aspx"></asp:HyperLink>
        <br /><span class="Author">By AW Community News Contributor</span><br />
        Streetscape and facade improvements project along 22nd street along with the annual Community Day
        Summer Festival highlight 2008.
        </div>
        <hr />
        <div style="text-align:justify;">
        <asp:HyperLink ID="lnkYouthPrograms" runat="server" CssClass="Header4" Text="Allegheny West Foundation Youth Programs Serve Community" NavigateUrl="~/AW/News_AWFYouth.aspx"></asp:HyperLink>
        <br /><span class="Author">By JACQUES LOUIS, AWF Director of Youth Development</span><br />
        Over the past 15 years, the Allegheny West Foundation (AWF), one of the oldest and most successful CDC's in Philadelphia, 
        has built a reputation as the premier provider of neighborhood-based youth services in Allegheny West. 
        </div>
        </td>
        
        <td style="width:25%; vertical-align:top;">
        <asp:Image ID="imgGCGE" runat="server" ImageUrl="~/AW/Images/GCGE.gif" />
        <br />
        <asp:Image ID="imgSNS" runat="server" ImageUrl="~/AW/Images/StopnSave.gif" />
        </td>
    </tr>
    </table>
    </div>
</asp:Content>
