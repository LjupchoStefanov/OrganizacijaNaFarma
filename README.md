# **Организација на фарма**
Windows Forms апликација изработена од: [Стефан Ристески 161515](https://github.com/Berkampe) и [Љупчо Стефанов 161522](https://github.com/LjupchoStefanov)
## [Линк до апликацијата](https://github.com/LjupchoStefanov/OrganizacijaNaFarma)

---

##1. **Опис на апликацијата**

Целта на апликацијата е со помош на Windows Forms да се овозможи организација на податоци од база за животинска фарма (за свињи).<br />
Апликацијата овозможува додавање, бришење, промена и визуелен приказ на податоците од базата.

---

##2. **Упатство за користењe**

При стартување на апликацијата се отвора следниов прозорец:
![Почетен прозорец](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Untitled.png)

Постојат пет различни опции кои може да се изберат на овој прозорец:
* **Единка** - ажурирање на податоци за една единка (свиња)
* **Репродукција** - ажурирање на податоци за една репродукција
* **Движење** - ажурирање на податоци за вкупниот број на единки во одреден вид на складилиште
* **Основен извештај** основен - приказ на одредени поосновни податоци за секој месец од годината
* **Задачи** - приказ на женски единки присутни во одредени фази од процесот на репродукција

###2.1 **Единка**

Се овозможува додавање на нова единка во базата со податоци. На сликата се прикажани информациите кои се додаваат.

![Додади](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Dodadi.png)

Се внесува шифрата на единката и се брише единката од базата со податоци.

![Бриши](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Brisi.png)

Се внесува шифрата на единката и се додава датумот на отфрлање од фармата. Во базата со податоци за секоја единка се чува и информација за тоа дали единката е активна. Сите единки што не се отфрлени се активни.
![Промени](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Promeni.png)

###2.2 **Репродукција**

Со внесување на шифрата на единката и со кликнување на копчето прикажи листа, се прикажуваат сите претходни и последната (активна) репродукција на женската единка.

![ОсновенПриказ](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaPrimer.png)

Се овозможува додавање на нова репродукција во базата со податоци. На сликата се прикажани информациите кои се додаваат.

![Додади](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaDodadi.png)

Се внесува шифрата на женската единка, на машката единка и на датумот на осеменување и се брише единката од базата со податоци.

![Бриши](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaIzbrisi.png)

Сите податоци за последната (активна) репродукција на женската единка кои се внесени во базата се прикажуваат на екранот. При додавање на репродукцијата се прикажуваат шифрата на шифрата на женската единка, на машката единка и на датумот на осеменување. Понатаму се внесуваат датумот на контролата и дали контролата е успешна. Доколку е успешна, понатаму се внесуваат податоци за датумот на опрасување, бројот на родени живородени прасиња, мртвородени прасиња и невитални прасиња. На крајот се внесуваат податоци за датумот на одбивање и бројот на одбиени прасиња.

![Промени](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/ReprodukcijaPromeniPodatoci.png)

###2.3 **Движење**

На следниот прозорец се прикажува вкупниот број на единки во секое складилиште. При одреден вид на додавање на нови единки во некое складилиште, одреден вид на отфрлање на единки од некое прасилиште или при пренос на единки од едно во друго складилиште, податоците за вкупниот број на единки во секое складилиште се ажурираат и на прозорецот како и соодветно и во базата со податоци.

![Движење](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Dvizenje.png)

###2.4 **Основен извештај**

Се прикажуваат бројот на родени живородени прасиња, мртвородени прасиња, невитални прасиња и одбиени прасиња за секој месец поединечно и за цела година. 

![Основен](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/OsnovenIzvestaj.png)

###2.5 **Задачи**

Се прикажуваат единките кои се подготвени за осеменување, контрола, опрасување и одбивање.

![Движење](https://github.com/LjupchoStefanov/OrganizacijaNaFarma/blob/master/%D0%A1%D0%BB%D0%B8%D0%BA%D0%B8%20%D0%BE%D0%B4%20%D0%B0%D0%BF%D0%BB%D0%B8%D0%BA%D0%B0%D1%86%D0%B8%D1%98%D0%B0%D1%82%D0%B0/Zadaci.png)

---

##3. **Краток опис на имплементација**

Преку класата ```public class DataAcess``` се овозможува конекција на работната околина на програмскиот јазик C# и базата со податоци преку конекциски стринг од серверот на кој е прикачена. Оваа класа содржи метод за извршување на одредена команда (Sql) во базата со податоци.
```
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
```
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
```
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

```
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

```
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
