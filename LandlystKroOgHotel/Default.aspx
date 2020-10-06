<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LandlystKroOgHotel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section id="banner">
        <div id="bannerInfoArea" class="col-lg-12 d-flex justify-content-center">
            <div id="bannerTextContainer" class="col-lg-6">
                <h1 class="bannerText">LANDLYST KRO OG HOTEL</h1>
                <p class="bannerText">Se vores værelser, eller læs mere om os herunder. Vi tilbyder både mulighed for enkelt værelse booking, lejning af selskabslokaler til arrangementer og brylupper.</p>
                <div id="readMoreArea">
                    <asp:LinkButton ID="LinkButtonReadMore" runat="server"><a href="#cards" class="btn btn-outline-light">SE VÆRELSER</a></asp:LinkButton>
                </div>
            </div>
        </div>
    </section>

    <!-- FOURTH SECTION - RELIGION -->

    <section id="aboutLandlyst">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12">
                    <article>
                        <h3>OM LANDLYST KRO OG HOTEL</h3>
                        <p>
                            I det sydfynske landskab, som byder på mange rekreative områder, ligger
                        kroen og hotellet Landlyst. Hotellet ejes af Marianne og Poul Johansen.
                        Hotellet har gennem det seneste år været lukket og der er foretaget en
                        gennemgribende renovering, og modernisering. Nu er dørene dog åbnet op
                        og der kan igen komme gæster på hotellet. På hotellet har man mulighed
                        </p>
                    </article>
                </div>
            </div>
        </div>
    </section>

    <div id="SaleSectionBackground" class="sectionBackground">
        <div class="sectionTextArea">
            <article class="sectionTextContainer">
                <h4 class="sectionText sectionHeadingItem1">TILBUD</h4>
                <h5 class="sectionText sectionParagraphItem2">Her hos landlyst har vi gode tilbud, du kan se dem her under!</h5>
            </article>
        </div>
    </div>

    <section id="sales">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12">
                    <div id="GolfOfferBackground" class="sectionBackground">
                        <article id="golfText">
                            <div id="golfHeading" class="row">
                                <h3>ALL-IN-ONE</h3>
                            </div>
                            <div class="row">
                                <div class="col-lg-6 golfInfoLeft">
                                    <p>
                                        Få 2 overnatninger med lækker morgenmadsbuffet,
                                        <br />
                                        3 retters aftenmenu inkl. vin, samt green fee til Danmarks flotteste golfbane
                                    </p>
                                </div>
                                <div class="col-lg-6 golfInfoRight">
                                    <h3>2195,-</h3>
                                    <p>
                                        pr. person
                                        <br />
                                        Gælder kun fredag til søndag
                                    </p>
                                </div>
                            </div>
                        </article>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <div id="RoomsSectionBackground" class="sectionBackground">
        <div class="sectionTextArea">
            <article class="sectionTextContainer">
                <h4 class="sectionText sectionHeadingItem1">VÆRELSER</h4>
                <h5 class="sectionText sectionParagraphItem2">Her under kan du se vores værelser.</h5>
            </article>
        </div>
    </div>

    <section id="cards" class="container">
        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12">
            <div class="card-columns">
                <div class="card" style="max-width: 319px;">
                    <img src="images/SingleRoom.jpg" class="card-img-top" alt="Card image" />

                    <div class="card-body">
                        <h4 class="card-title">Single</h4>
                        <p class="card-text">Each merged squad salts the wild porter. Should the charmed church dodge a camera? The gown litters the rhyme. Another discrete elevator defects over the target.</p>
                        <a href="SingleRoom.aspx" class="btn btn-success">Læs mere</a>
                    </div>
                </div>

                <div class="card" style="max-width: 319px;">
                    <img src="images/TheRibbleSuite.jpg" class="card-img-top" alt="Card image" />

                    <div class="card-body">
                        <h4 class="card-title">Double</h4>
                        <p class="card-text">Each merged squad salts the wild porter. Should the charmed church dodge a camera? The gown litters the rhyme. Another discrete elevator defects over the target.</p>
                        <a href="DoubleRoom.aspx" class="btn btn-success">Læs mere</a>
                    </div>
                </div>

                <div class="card" style="max-width: 319px;">
                    <img src="images/MiscBedrooms.jpg" class="card-img-top" alt="Card image" />

                    <div class="card-body">
                        <h4 class="card-title">Luxury Double</h4>
                        <p class="card-text">Each merged squad salts the wild porter. Should the charmed church dodge a camera? The gown litters the rhyme. Another discrete elevator defects over the target.</p>
                        <a href="DoubleLuxuryRoom.aspx" class="btn btn-success">Læs mere</a>
                    </div>
                </div>

                <div class="card" style="max-width: 319px;">
                    <img src="images/TheKempleSuite.jpg" class="card-img-top" alt="Card image" />

                    <div class="card-body">
                        <h4 class="card-title">Suite</h4>
                        <p class="card-text">Each merged squad salts the wild porter. Should the charmed church dodge a camera? The gown litters the rhyme. Another discrete elevator defects over the target.</p>
                        <a href="Suite.aspx" class="btn btn-success">Læs mere</a>
                    </div>
                </div>

                <div class="card" style="max-width: 319px;">
                    <img src="images/The-Snug.jpg" class="card-img-top" alt="Card image" />

                    <div class="card-body">
                        <h4 class="card-title">Conference Room</h4>
                        <p class="card-text">Each merged squad salts the wild porter. Should the charmed church dodge a camera? The gown litters the rhyme. Another discrete elevator defects over the target.</p>
                        <a href="ConferenceRoom.aspx" class="btn btn-success">Læs mere</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
