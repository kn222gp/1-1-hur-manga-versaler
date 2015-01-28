<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hur många versaler?</h1>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="InputTextBox" runat="server" Height="115px" Width="290px" TextMode="MultiLine"></asp:TextBox>
        
    </div>
    <div>
        <asp:Button ID="CountButton" runat="server" Text="Räkna antalet versaler" OnClick="CountButton_Click" />
    </div>
    <div>
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
