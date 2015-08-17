﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="WebApplication.Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top" style="float: right">
        <input type="hidden" name="cmd" value="_s-xclick" />
        <table>
            <tr>
                <td>
                    <input type="hidden" name="on0" value="贊助網站永續營運" />贊助網站永續營運:
                    <select name="os0">
                        <option value="此網站極有幫助">此網站極有幫助 NT$1,000 TWD</option>
                        <option value="此網站非常有幫助">此網站非常有幫助 NT$500 TWD</option>
                        <option value="此網站十分有幫助">此網站十分有幫助 NT$100 TWD</option>
                    </select>
                </td>
                <td>
                    <input type="image" src="https://www.paypalobjects.com/zh_TW/TW/i/btn/btn_paynowCC_LG.gif" name="submit" alt="PayPal － 更安全、更簡單的線上付款方式！" /></td>
            </tr>
        </table>
        <input type="hidden" name="currency_code" value="TWD" />
        <input type="hidden" name="encrypted" value="-----BEGIN PKCS7-----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-----END PKCS7-----
" />
        <img alt="" border="0" src="https://www.paypalobjects.com/zh_TW/i/scr/pixel.gif" width="1" height="1" />
    </form>
</body>
</html>