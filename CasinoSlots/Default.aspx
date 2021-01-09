<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CasinoSlots.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>~ Casino Slots Game ~</h1>
            <div class="auto-style1">
                <br />
                <br />
                <asp:Image ID="Image1" runat="server" Height="161px" Width="161px" />
                <asp:Image ID="Image2" runat="server" Height="161px" Width="161px" />
                <asp:Image ID="Image3" runat="server" Height="161px" Width="161px" />
                <br />
                <br />
                Your Bet: <asp:TextBox ID="txbxBet" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnPullLevel" runat="server" Text="Pull the Level" />
                <br />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblMoney" runat="server"></asp:Label>
                <br />
                <br />
                1 Cherry = x2 Your Bet<br />
                2 Cherries = x3 Your Bet<br />
                3 Cherries = x4 Your Bet<br />
                3 HorseShoes = JACKPOT = x100 Your Bet</div>
        </div>
    </form>
</body>
</html>
