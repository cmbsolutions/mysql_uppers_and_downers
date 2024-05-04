Imports CMBSolutions.Db.infoSchema

Public Class CompareProject
    Property DbFrom As Manager
    Property DbTo As Manager

    Property Context As Models.CompareContext

    Sub New(f As Manager, t As Manager)
        DbFrom = f
        DbTo = t

        Context = New Models.CompareContext(f, t)
    End Sub



End Class
