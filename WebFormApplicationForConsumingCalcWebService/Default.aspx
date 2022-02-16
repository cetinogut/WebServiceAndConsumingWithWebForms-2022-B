<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormApplicationForConsumingCalcWebService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
        <p>&nbsp;&nbsp;</p>
    </div>

    <table>
        <tr>
            <td>First Value</td>
            <td></td>
            <td>
                <asp:TextBox ID="txtFirstValue" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td>Second Value</td>
            <td></td>
            <td>
                <asp:TextBox ID="txtSecondValue" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td>Operation</td>
            <td></td>
            <td>
                <asp:TextBox ID="txtOperation" runat="server"></asp:TextBox>
             </td>
        </tr>
        <tr>
           <td colspan="3" align="right">
               <asp:Button ID="btnDivideBy0" runat="server" OnClick="btnDivideBy0_Click" Text="Divide by 0" />
               <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click"/>
           </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
   

</asp:Content>
