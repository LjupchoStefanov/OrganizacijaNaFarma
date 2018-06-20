# **Организација на фарма**
Windows Forms апликација изработена од: [Стефан Ристески 161515](https://github.com/Berkampe) и [Љупчо Стефанов 161522](https://github.com/LjupchoStefanov)

---

## 1. **Опис на апликацијата**

Целта на апликацијата е со помош на Windows Forms да се овозможи организација на податоци од база за фарма за свињи.<br />
Апликацијата овозможува додавање, бришење, промена и визуелен приказ на податоците од базата.

---

## 2. **Упатство за користењe**

При стартување на апликацијата се отвора следниов прозорец:
![Почетен прозорец](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Untitled.png)

Постојат пет различни опции кои може да се изберат на овој прозорец:
* **Единка** - ажурирање на податоци за една единка (свиња)
* **Репродукција** - ажурирање на податоци за една репродукција
* **Движење** - ажурирање на податоци за вкупниот број на единки во одреден вид на складилиште
* **Основен извештај** основен - приказ на одредени поосновни податоци за секој месец од годината
* **Задачи** - приказ на женски единки присутни во одредени фази од процесот на репродукција

### 2.1 **Единка**

Се овозможува додавање на нова единка во базата со податоци. На сликата се прикажани информациите кои се додаваат:

![Додади](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Dodadi.png)

Се внесува шифрата на единката и се брише единката од базата со податоци:

![Бриши](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Brisi.png)

Се внесува шифрата на единката и се додава датумот на отфрлање од фармата. Во базата со податоци за секоја единка се чува и информација за тоа дали единката е активна. Сите единки што не се отфрлени се активни:
![Промени](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Promeni.png)

### 2.2 **Репродукција**

Со внесување на шифрата на единката и со кликнување на копчето прикажи листа, се прикажуваат сите претходни и последната (активна) репродукција на женската единка:

![ОсновенПриказ](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaPrimer.png)

Се овозможува додавање на нова репродукција во базата со податоци. На сликата се прикажани информациите кои се додаваат:

![Додади](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaDodadi.png)

Се внесува шифрата на женската единка, на машката единка и датумот на осеменување и се брише единката од базата со податоци:

![Бриши](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaIzbrisi.png)

Сите податоци за последната (активна) репродукција на женската единка кои се внесени во базата се прикажуваат на екранот. При додавање на репродукцијата се прикажуваат шифрата на женската единка, на машката единка и на датумот на осеменување. Понатаму се внесуваат датумот на контролата и дали контролата е успешна. Доколку е успешна, понатаму се внесуваат податоци за датумот на опрасување, бројот на родени живородени прасиња, мртвородени прасиња и невитални прасиња. На крајот се внесуваат податоци за датумот на одбивање и бројот на одбиени прасиња:

![Промени](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaPromeniPodatoci.png)

### 2.3 **Движење**

На следниот прозорец се прикажува вкупниот број на единки во секое складилиште. При одреден вид на додавање на нови единки во некое складилиште, одреден вид на отфрлање на единки од некое прасилиште или при пренос на единки од едно во друго складилиште, податоците за вкупниот број на единки во секое складилиште се ажурираат и на прозорецот како и соодветно и во базата со податоци:

![Движење](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Dvizenje.png)

### 2.4 **Основен извештај**

Се прикажуваат бројот на родени живородени прасиња, мртвородени прасиња, невитални прасиња и одбиени прасиња за секој месец поединечно и за цела година:

![Основен](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/OsnovenIzvestaj.png)

### 2.5 **Задачи**

Се прикажуваат единките кои се подготвени за осеменување, контрола, опрасување и одбивање:

![Движење](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Zadaci.png)

---

## 3. **Краток опис на имплементација**

Преку класата ```public class DataAcess``` се овозможува конекција на работната околина на програмскиот јазик C# и базата со податоци преку конекциски стринг од серверот на кој е прикачена. Оваа класа содржи метод за извршување на одредена команда (Sql) во базата со податоци.
```csharp
public void cmdCommand(SqlCommand cmd)
        {
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
```

Класата ```public class MakeDate``` го содржи следниов метод:

```csharp
public static string makeDate(String date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date.Substring(6, 4));
            sb.Append(date.Substring(3, 2));
            sb.Append(date.Substring(0, 2));

            return sb.ToString();
        }
```
Датумот кој се внесува како стринг со формат "dd-mm-yyyy", со помош на вградениот метод substring се трансформира во стринг "yyyymmdd", формат потребен за понатамошно негово кастирање во базата со податоци во тип datetime.

Класите ```public class ОS```, ```public class Reproduction``` и ```public class Dvizenje``` ги содржат соодветно податоците кои се додаваат, бришат или менуваат при кликнување на соодветните копчињата од прозорците Единка, Репродукција и Движење, кои претходно се објаснети.

Во прилог се прикажани неколку примери кодови за задавање на командите кои се извршуваат во базата со податоци преку формите со помош на конекцијата од класата ```public class DataAcess```.

* Пример 1 - Додавање нова репродукција во базата

```csharp
 private void buttonDodadi_Click(object sender, EventArgs e)
        {
            ReprodukcijaFormDodadi newForm = new ReprodukcijaFormDodadi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Insert Into tblReprodukcija(ID,FMajka,MTatko,OsemenuvanjeDatum,Kontrola) " +
                    "Values(0,N'" + newForm.Reprodukcija.Zensko + "',N'" + newForm.Reprodukcija.Masko + 
                    "',cast('" + newForm.Reprodukcija.Osemena + "' as datetime),'" + newForm.Reprodukcija.Kontrola + "')", DA.getConnection());
                DA.cmdCommand(cmd1);
                Refresh();
            }
        }
```

* Пример 2 - Бришење на единка од базата

```csharp
 private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            OSFormIzbrisi newForm = new OSFormIzbrisi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                SqlCommand cmd1 = new SqlCommand("Delete from tblOs Where FMajka = N'" + newForm.Code + "'", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }
 ``` 

* Пример 3 - Промена на податоци за единка во базата

```csharp
 private void buttonPromeni_Click(object sender, EventArgs e)
        {
            OSFormPromeni newForm = new OSFormPromeni();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                SqlCommand cmd1 = new SqlCommand("UPDATE tblOS SET IzlezDatum = N'" + newForm.Datum + "', Aktivno = N'" + newForm.Aktivno + "' Where FMajka = N'" + newForm.Code + "'", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }
 ``` 
 
 Со помош на на ***iTextSharp*** во PDF формат се креира основниот извештај чија содржина е објаснета претходно. 
 
 ```csharp
         Document pdfDoc = new Document();
            SqlDataReader reader = null;
            try
            {
                string FileName = null;
                if (FileName == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Osnoven izvestaj (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Osnoven izvestaj";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = saveFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                PdfWriter pdf = PdfWriter.GetInstance(pdfDoc, new FileStream(FileName, FileMode.Create));
                pdfDoc.Open();
                string myFont = @"C:\Windows\Fonts\arial.ttf";
                iTextSharp.text.pdf.BaseFont bfR;
                bfR = iTextSharp.text.pdf.BaseFont.CreateFont(myFont,
                  iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                  iTextSharp.text.pdf.BaseFont.EMBEDDED);

                iTextSharp.text.BaseColor clrBlack =
                    new iTextSharp.text.BaseColor(0, 0, 0);
                iTextSharp.text.Font fntHead =
                    new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, clrBlack);
                //pdfDoc.Add(new Paragraph("ТЕСТ", fntHead));
                PdfPTable table = new PdfPTable(5);
                //PdfPCell cell = new PdfPCell(new Phrase("ОСНОВЕН ИЗВЕШТАЈ"));
                PdfPCell cell = new PdfPCell(new Phrase("OSNOVEN IZVESTAJ"));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                table.AddCell("Meseci");
                table.AddCell("Rodeni");
                table.AddCell("Mrtvo Rodeni");
                table.AddCell("Nevitalni");
                table.AddCell("Odbieni prasinja");
                long vkupnoRodeni = 0;
                long vkupnoMrtvoRodeni = 0;
                long vkupnoNevitalni = 0;
                long vkupnoOdbieniPrasinja = 0;

                DataAcess da = new DataAcess();
                SqlConnection conn = da.getConnection();
                conn.Open();
                for (int i = 1; i < 13; i++)
                {
                    int k = i + 1;
                    String str = String.Format("Select * FROM tblReprodukcija Where OdbivanjeDatum > DATEADD(MONTH, {0}, GetDate()) and OdbivanjeDatum < DATEADD(MONTH, {1}, GetDate())", -k, -i);
                    SqlCommand cmd = new SqlCommand(str);
                    //SqlCommand cmd = new SqlCommand("Select * FROM tblReprodukcija Where OdbivanjeDatum > DATEADD(MONTH, -'" + k + "' , GetDate()) and OdbivanjeDatum < DATEADD(MONTH, -'" + i +"', GetDate())");
                    cmd.Connection = conn;
                    reader = cmd.ExecuteReader();
                    List<Reproduction> lista = new List<Reproduction>();
                    while (reader.Read())
                    {
                        string Zensko = reader["FMajka"].ToString();
                        string Masko = reader["MTatko"].ToString();
                        string Osemena = reader["OsemenuvanjeDatum"].ToString();
                        string KontrolaDatum = reader["KontrolaDatum"].ToString();
                        bool Kontrola = Boolean.Parse(reader["Kontrola"].ToString());
                        string Oprasena = reader["OprasuvanjeDatum"].ToString();
                        float Rodeni = 0;
                        if (reader["ZivoRodeniPrasinja"].ToString() != "") Rodeni = float.Parse(reader["ZivoRodeniPrasinja"].ToString());
                        float MrtvoRodeni = 0;
                        if (reader["MrtvoRodeniPrasinja"].ToString() != "") MrtvoRodeni = float.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                        float Nevitalni = 0;
                        if (reader["NevitalniPrasinja"].ToString() != "") Nevitalni = float.Parse(reader["NevitalniPrasinja"].ToString());
                        string Odbivanje = reader["OdbivanjeDatum"].ToString();
                        float OdbieniPrasinja = 0;
                        if (reader["OdbieniPrasinja"].ToString() != "") OdbieniPrasinja = float.Parse(reader["OdbieniPrasinja"].ToString());
                        Reproduction pom = new Reproduction(Zensko, Masko, Osemena, Kontrola, KontrolaDatum, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja);
                        lista.Add(pom);
                    }
                    int rodeni = 0;
                    int Mrtvi = 0;
                    int nevitalni = 0;
                    int odbieni = 0;
                    for (int m = 0; m < lista.Count; m++)
                    {
                        rodeni += (int)lista[i].Rodeni;
                        Mrtvi += (int)lista[i].MrtvoRodeni;
                        nevitalni += (int)lista[i].Nevitalni;
                        odbieni += (int)lista[i].OdbieniPrasinja;
                    }
                    table.AddCell(i.ToString());
                    vkupnoRodeni += rodeni;
                    table.AddCell(rodeni.ToString());
                    vkupnoMrtvoRodeni += Mrtvi;
                    table.AddCell(Mrtvi.ToString());
                    vkupnoNevitalni += nevitalni;
                    table.AddCell(nevitalni.ToString());
                    vkupnoOdbieniPrasinja += odbieni;
                    table.AddCell(odbieni.ToString());
                    reader.Close();
                }
                table.AddCell("Vkupno");
                table.AddCell(vkupnoRodeni.ToString());
                table.AddCell(vkupnoMrtvoRodeni.ToString());
                table.AddCell(vkupnoNevitalni.ToString());
                table.AddCell(vkupnoOdbieniPrasinja.ToString());
                pdfDoc.Add(table);
                MessageBox.Show("Креаиран е PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {


                pdfDoc.Close();
            }
```
