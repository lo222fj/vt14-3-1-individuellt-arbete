<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ApartmentBooking.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lägenhetsbokning</title>
    <link href="Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <h1 id="mainHeader">Lägenhetsbokning</h1>

            <div id="main">
                <h2>Kunder</h2>
                <p>
                    Välj kund för att se bokningar och lägga till nya bokningar.
                </p>
                <asp:ListView ID="CustomerListView" runat="server"
                    ItemType="ApartmentBooking.Model.Customer"
                    SelectMethod="CustomerListView_GetData"
                    DataKeyNames="CustomerId">
                    <LayoutTemplate>
                        <table>
                            <tr>
                                <th>Förnamn</th>
                                <th>Efternamn</th>
                                <th>Adress</th>
                                <th>Postnummer</th>
                                <th>Ort</th>
                            </tr>
                            <%--Platshållare för varje item dvs varje ny rad --%>
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="FirstNameLabel" runat="server" Text='<%#: Item.FirstName %>' />
                            </td>
                            <td>
                                <asp:Label ID="LastNameLabel" runat="server" Text='<%#: Item.LastName %>' />
                            </td>
                            <td>
                                <asp:Label ID="AddressLabel" runat="server" Text='<%#: Item.Address %>' />
                            </td>
                            <td>
                                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%#: Item.PostalCode %>' /></td>
                            <td>
                                <asp:Label ID="CityLabel" runat="server" Text='<%#: Item.City %>' />
                            </td>
                        </tr>
                     </ItemTemplate>
                    <EmptyDataTemplate>
                        <%--Det här visas när kunduppgifter saknas i databasen --%>
                        <p>
                            Kunduppgifter saknas
                        </p>
                    </EmptyDataTemplate>
                </asp:ListView>

            </div>

        </div>
    </form>
</body>
</html>
