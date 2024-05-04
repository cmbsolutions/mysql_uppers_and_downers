Public Class LexerStyles
    Public Shared Sub SetMySQLStyle(lexer As ScintillaNET.Scintilla)
        ResetLexer(lexer)

        lexer.Lexer = ScintillaNET.Lexer.Sql

        lexer.CreateDocument()

        lexer.Styles(ScintillaNET.Style.Sql.Default).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Default).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Default).ForeColor = Color.Gainsboro
        lexer.Styles(ScintillaNET.Style.Sql.Default).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Default).SizeF = 10.0F
        lexer.Styles(ScintillaNET.Style.Sql.Comment).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Comment).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Comment).ForeColor = Color.FromArgb(102, 116, 123)
        lexer.Styles(ScintillaNET.Style.Sql.Comment).Italic = True
        lexer.Styles(ScintillaNET.Style.Sql.Comment).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Comment).SizeF = 10.0F
        lexer.Styles(ScintillaNET.Style.Sql.Number).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Number).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Number).ForeColor = Color.FromArgb(255, 205, 34)
        lexer.Styles(ScintillaNET.Style.Sql.Number).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Number).SizeF = 10.0F

        lexer.Styles(ScintillaNET.Style.Sql.Word).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Word).Bold = True
        lexer.Styles(ScintillaNET.Style.Sql.Word).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Word).ForeColor = Color.FromArgb(147, 199, 99)
        lexer.Styles(ScintillaNET.Style.Sql.Word).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Word).SizeF = 10.0F
        lexer.Styles(ScintillaNET.Style.Sql.Word).Weight = 700

        lexer.Styles(ScintillaNET.Style.Sql.Word2).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Word2).Bold = True
        lexer.Styles(ScintillaNET.Style.Sql.Word2).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Word2).ForeColor = Color.FromArgb(147, 199, 99)
        lexer.Styles(ScintillaNET.Style.Sql.Word2).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Word2).SizeF = 10.0F
        lexer.Styles(ScintillaNET.Style.Sql.Word2).Weight = 700

        lexer.Styles(ScintillaNET.Style.Sql.[String]).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.[String]).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.[String]).ForeColor = Color.FromArgb(236, 118, 0)
        lexer.Styles(ScintillaNET.Style.Sql.[String]).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.[String]).SizeF = 10.0F

        lexer.Styles(ScintillaNET.Style.Sql.Character).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Character).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.Character).ForeColor = Color.FromArgb(236, 118, 0)
        lexer.Styles(ScintillaNET.Style.Sql.Character).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.Character).SizeF = 10.0F

        lexer.Styles(ScintillaNET.Style.Sql.[Operator]).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.[Operator]).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Sql.[Operator]).ForeColor = Color.FromArgb(232, 226, 183)
        lexer.Styles(ScintillaNET.Style.Sql.[Operator]).Size = 10
        lexer.Styles(ScintillaNET.Style.Sql.[Operator]).SizeF = 10.0F

        lexer.Styles(ScintillaNET.Style.Sql.Identifier).BackColor = Color.FromArgb(-14803426)
        lexer.Styles(ScintillaNET.Style.Sql.Identifier).ForeColor = Color.Gainsboro

        lexer.SetKeywords(0, My.Resources.mysql_keywords)
    End Sub

    Private Shared Sub ResetLexer(ByRef lexer As ScintillaNET.Scintilla)
        lexer.StyleClearAll()

        lexer.HScrollBar = True
        lexer.VScrollBar = True

        lexer.Styles(ScintillaNET.Style.Default).BackColor = Color.FromArgb(30, 30, 30)
        lexer.Styles(ScintillaNET.Style.Default).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Default).ForeColor = Color.FromArgb(220, 220, 220)
        lexer.Styles(ScintillaNET.Style.Default).Size = 10

        lexer.Styles(ScintillaNET.Style.LineNumber).BackColor = Color.FromArgb(30, 30, 30)
        lexer.Styles(ScintillaNET.Style.LineNumber).ForeColor = Color.FromArgb(43, 145, 175)
        lexer.Styles(ScintillaNET.Style.LineNumber).Font = lexer.Styles(ScintillaNET.Style.Default).Font
        lexer.Styles(ScintillaNET.Style.LineNumber).Size = lexer.Styles(ScintillaNET.Style.Default).Size

        lexer.Margins(0).Type = ScintillaNET.MarginType.Number
        lexer.Margins(0).Width = 30
    End Sub
End Class
