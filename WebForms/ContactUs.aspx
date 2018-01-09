<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="BlackLight.Recruitment.WebForms.ContactUs" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Contact Us</h2>
    
    <asp:Panel runat="server" ID="ContactFormPanel">
        <div>
            <asp:Label ID="validationMessage" Text="" runat="server" />
        </div>
        <div>
            <asp:Label runat="server" AssociatedControlID="Name" Text="Your Name:" />
            <asp:TextBox runat="server" ID="Name" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Name" Text="Name is required" />
        </div>
        <div>
            <asp:Label runat="server" AssociatedControlID="Email" Text="Your Email Address:" />
            <asp:TextBox runat="server" ID="Email" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" Text="Pleas enter your email" Display="Dynamic" />
            <asp:RegularExpressionValidator runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" Text="Pleas enter valid email" Display="Dynamic"/>
        </div>
        <div>
            <asp:Label runat="server" AssociatedControlID="Message" Text="Your Message" /><br />
            <asp:TextBox runat="server" ID="Message" TextMode="MultiLine" Columns="50" Rows="5" />
        </div>

        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
            <!-- Todo: send this info back to the server -->
        </div>
    </asp:Panel>

    <asp:Panel runat="server" ID="FeedbackPanel" Visible="false">
        <p>Thanks for contacting us, <asp:Literal ID="UserName" runat="server" Text="User Name"/>, we'll get back to you soon.</p>
        <!-- Todo: show this panel after submission -->
    </asp:Panel>

</asp:Content>
