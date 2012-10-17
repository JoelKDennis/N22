<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RealEstate.aspx.cs" Inherits="North22ndStreet.Web.RealEstate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .realEstateListingDIV
        {
        	width:400px;border:Solid 1px #C40000; font-family:Tahoma; color:Black; font-size:12px; 
        	margin-left:auto; margin-right:auto; padding:4px 4px 4px 4px;
        }
        .realEstateListtingAddressText
        {
        	font-size:13px; color:#C40000; font-weight:bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TopAdvertisement" runat="server">
<div style="text-align:center; padding-top:5px;">
    <span style="font-family:Tahoma; font-size:12px; color:#FFF;">What's happening in our neighborhood? Read it here!</span>
    <br />
    <a href="AW/default.aspx">
    <img src="AW/Images/AWHeaderAD.gif" alt="Read Online!" title="Allegheny West Community News Journal" width="400px" />
    </a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span style="font-size:18px; font-weight:bold; font-family:Tahoma; color:#C40000;">
Real Estate
</span>
<br />
<div style="text-align:center">
<div style="border:Solid 1px #C40000; margin-left:auto; margin-right:auto; width:560px; text-align:center;">

    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR SALE
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2859 N 22nd Street </span>
                    <br /> 
                2 Story Property. 1st floor Commercial. Former Beauty Salon fully Equipped. 
                Established Over 50 years. 2nd Floor 2 Bedroom Apartment with Separate Entrance. Bldg well Maintained
            </p>
    </div>

    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR SALE
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2938 N. 22nd Street</span>
                    <br /> 
                 3 Story Property. 1st Floor Commercial Former Doctors Office with Waiting Room 3 Examination Rooms Rear Office. Established 35 Years. Excellent Location for Professional Office. 2nd and 3rd floor with separate entrance can be developed into apartments.
            </p>
    </div>

    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR RENT
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2920 N 22nd Street</span>
                    <br /> 
                  Newly Renovated 1000 Square Ft. Excellent Retail Location 
            </p>
    </div>
    
    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR RENT
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2922 N 22nd Street</span>
                    <br /> 
                  Newly Renovated 1000 Square Ft. Excellent Retail Location 
            </p>
    </div>
    
    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR RENT
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2927 N 22nd Street </span>
                    <br /> 
                  Former Accessory & Hand Bag Boutique 900 Square Ft  
            </p>
    </div>    

    <br />
    <span style="font-size:16px; font-weight:bold; font-style:italic; font-family:Tahoma; color:#C40000;">
        FOR RENT
    </span>
    <br />
    <div class="realEstateListingDIV"> 
            <p style="text-align:center">
                <span class="realEstateListtingAddressText">2929 N 22nd Street </span>
                    <br /> 
                  Former Pizza  & Seafood Restaurant Zoned Eat In or Take Out 
            </p>
    </div>    

<br />
<br />
</div>
</div>
</asp:Content>
