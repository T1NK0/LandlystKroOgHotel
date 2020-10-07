<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleRoom.aspx.cs" Inherits="LandlystKroOgHotel.SingleRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-6">
                <div class="col-md-12 CreateReservation">
                    <h1>ENKELT VÆRELSE</h1>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. In iaculis at quam ac sollicitudin.
                    Sed consequat venenatis imperdiet. Maecenas lobortis nisi id sapien convallis, a gravida tortor consectetur.
                    Aliquam commodo urna nisi, non malesuada nulla consectetur at. Sed aliquam quam ipsum, quis semper felis eleifend sit amet.
                    Sed blandit pharetra nisl vel gravida.
                    </p>

                    <p>
                        Curabitur lorem diam, tempus ut mauris vitae, facilisis maximus risus.
                    Curabitur dapibus pellentesque tempus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
                    Vestibulum mauris metus, luctus dapibus est a, auctor malesuada ante. Integer in venenatis libero, eu rhoncus sem.
                    Sed gravida ornare ipsum, non cursus nibh pretium vestibulum. Suspendisse quis tellus neque.
                    </p>
                </div>
            </div>

            <div class="col-lg-6">
                <div class="col-md-12 CreateReservation">
                    <div class="row">
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal1" runat="server">Fornavn</asp:Literal>
                            <asp:TextBox ID="TextBoxFirstName" runat="server" placeholder="Fornavn" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal2" runat="server">Efternavn</asp:Literal>
                            <asp:TextBox ID="TextBoxLastName" runat="server" placeholder="Efternavn" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Literal ID="Literal3" runat="server">Addresse</asp:Literal>
                            <asp:TextBox ID="TextBoxAddress" runat="server" placeholder="Addresse" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal4" runat="server">Post nr.</asp:Literal>
                            <asp:TextBox ID="TextBoxPostal" runat="server" placeholder="Post nr." CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal5" runat="server">By</asp:Literal>
                            <asp:TextBox ID="TextBoxCity" runat="server" placeholder="By" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Literal ID="Literal11" runat="server">Telefonnummer</asp:Literal>
                            <asp:TextBox ID="TextBoxTelephone" runat="server" placeholder="Telefonnummer" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Literal ID="Literal6" runat="server">Email</asp:Literal>
                            <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal9" runat="server">Check ind</asp:Literal>
                            <asp:Calendar ID="CalendarCheckIn" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal10" runat="server">Check ud</asp:Literal>
                            <asp:Calendar ID="CalendarCheckOut" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal8" runat="server">Aircondition</asp:Literal>
                            <br />
                            <asp:RadioButtonList ID="ACChoice" runat="server" OnSelectedIndexChanged="ACChoice_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Value="Yes">Ja</asp:ListItem>
                                <asp:ListItem Value="No" Selected="True">Nej</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-lg-6">
                            <asp:Literal ID="Literal7" runat="server">Værelse</asp:Literal>
                            <asp:DropDownList ID="DropDownListRoom" runat="server" CssClass="form-control"></asp:DropDownList>
                            <%-- høre til dropdown:DataTextField="RoomNumber" DataValueField="RoomID" <asp:SqlDataSource runat="server" ID="SingelroomSelectRoom" ConnectionString='<%$ ConnectionStrings:LandlystConnectionString %>' SelectCommand="SELECT RoomID, RoomNumber FROM Room INNER JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID WHERE RoomType.RoomTypeID = 1 AND Room.EquipmentID IS NULL"></asp:SqlDataSource>--%>
                        </div>
                    </div>
                    <asp:Button ID="ButtonCreateReservation" runat="server" Text="Reserver værelse" class="btn btn-success" OnClick="ButtonCreateReservation_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
