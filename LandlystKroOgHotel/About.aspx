<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="LandlystKroOgHotel.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Enkelt værelse</h1>

    <div class="container">
        <div class="row">
            <div class="col-lg-12">
            </div>
            <div class="col-lg-6">
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>
            <div class="col-lg-6">
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </div>
        </div>
    </div>


</asp:Content>
