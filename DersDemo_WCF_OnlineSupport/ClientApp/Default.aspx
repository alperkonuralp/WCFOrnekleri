<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="jquery-1.4.2.min.js" type="text/javascript"></script>

    <style type="text/css">
        #tbMessage
        {
            height: 100px;
            width: 200px;
        }
        #bSend2
        {
            height: 100px;
            width: 100px;
        }
        #dChat
        {
            height: 200px;
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:HiddenField ID="hfUserID" runat="server" />
    <asp:HiddenField ID="hfUserName" runat="server" />
    <asp:HiddenField ID="hfOperatorID" runat="server" />
    <asp:Panel runat="server" ID="p1">
        Adınız :
        <asp:TextBox ID="tbName" runat="server" />
        <asp:Button ID="bSend" runat="server" Text="Giriş" OnClick="bSend_Click" />
    </asp:Panel>
    <asp:Panel runat="server" ID="p2" Visible="false">
        Aktif Operatörler :
        <asp:DropDownList ID="ddl" runat="server" />
        <asp:Button ID="bStart" runat="server" Text="Başla" OnClick="bStart_Click" />
    </asp:Panel>
    <asp:Panel runat="server" ID="p3" Visible="false">
        <div id="dChat">
        </div>
        <input type="text" id="tbMessage" name="tbMessage" />
        <input type="button" id="bSend2" name="bsend2" value="Gönder" />

        <script type="text/javascript">
            $(function() {
                window.lastOperationTime = '2010-01-01';
                $("#bSend2").click(function() {
                    $.ajax({
                        type: 'POST',
                        url: 'sendMessage.ashx',
                        dataType: 'text',
                        data: {
                            u: $("input:hidden[name$=hfUserID]").val(),
                            o: $("input:hidden[name$=hfOperatorID]").val(),
                            m: $("input#tbMessage").val()
                        },
                        success: function(data) {
                            $("input#tbMessage").val("");
                        }
                    });
                });
                setTimeout("GetMessages();", 2000);
            });
            function GetMessages() {
                $.ajax({
                    type: "POST",
                    url: 'getMessage.ashx',
                    dataType: 'html',
                    data: {
                        u: $("input:hidden[name$=hfUserID]").val(),
                        o: $("input:hidden[name$=hfOperatorID]").val()
                    },
                    success: function(data) {
                        $("div#dChat").append(data);
                        setTimeout("GetMessages();", 2000);
                    }
                });
            }
        </script>

    </asp:Panel>
    </form>
</body>
</html>
