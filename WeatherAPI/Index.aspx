<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WeatherAPI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCityName" runat="server"></asp:TextBox>
            <asp:Button ID="btnWeatherData" runat="server" Text="Weather ForeCast" ToolTip="click for Weather details" OnClick="btnWeatherData_Click" />
            <hr />

            <table id="tblWeather" runat="server" border="2" cellpadding="0" cellspacing="0" visible="false">
                <tr>
                    <th colspan="2">Weather Information
                    </th>
                </tr>
                <tr>
                    <td rowspan="3">
                        <asp:Image ID="imgWeatherIcon" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity_Country" runat="server" />
                        <asp:Image ID="imgCountryFlag" runat="server" />
                        <asp:Label ID="lblDescription" runat="server" />
                        Humidity:<asp:Label ID="lblHumidity" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Temperature:(Min:<asp:Label ID="lblTempMin" runat="server" />
                        Max: <asp:Label ID="lblTempMax" runat="server" />)
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <p>
        &nbsp;
    </p>
</body>
</html>
