
# Sistema de para registros de vacunacion 

## User Manual

Download the manual from the repository also incluided in the Release v1.0.1  

## Requirements
> Requirements used to build and run :

- Clone github.com/juarezgonzalez/gestorvacunacion/ Repository to your machine 
- Windows 10  
- .NET IDE [(JetBrains Raider 2021.1.1)](https://www.jetbrains.com/es-es/rider/) 
- Microsoft SQL Server 2019 
- Microsoft .NET Core 5.0
- Restored NuGet Packages
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.EntityFrameworkCore.SqlServer

> Requirements to execute
1. OS Microsoft Windows  7/8/8.1/10
2. [Microsoft SQL Server 2019](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) as the relational database management system installed 
3. Download and install [Release v1.0.2](https://github.com/UCASV/proyecto-final-grupo-35/releases/tag/1.0.2) on your PC [(follow the instructions)](https://github.com/UCASV/proyecto-final-grupo-35#instalation-instructions)

#  

## Instalation Instructions

1. Download and install [Microsoft SQL Server 2019 Express](https://www.microsoft.com/es-co/download/details.aspx?id=101064)
    - Install the basic configuration
        ![SQLBasic conf img](https://raw.githubusercontent.com/UCASV/proyecto-final-grupo-35/master/Programacion%20Orientada%20a%20Objetos/Docs/Resources/Instalation1.png "SQLBasic")

    - Make sure to left the data predefined
        ![SQLBasic Data img](https://raw.githubusercontent.com/UCASV/proyecto-final-grupo-35/master/Programacion%20Orientada%20a%20Objetos/Docs/Resources/Instalation2.png "SQLData")

    - Now you can close the window                   
    
2. Download [Release v1.0.2](https://github.com/UCASV/proyecto-final-grupo-35/releases/tag/1.0.2) on your PC

3. Execute SRVInstall.exe file

    ![Svr file img](https://raw.githubusercontent.com/UCASV/proyecto-final-grupo-35/master/Programacion%20Orientada%20a%20Objetos/Docs/Resources/SVRInstallerImg.png "Svr file")

    - Since this is not a signed .exe file, this screen will be shown and some Antivirus may erase the file 
    
    - Press "Más Informacion" underlined text then "Ejecutar de todas formas" 

     ![Svr winScree img](https://raw.githubusercontent.com/UCASV/proyecto-final-grupo-35/master/Programacion%20Orientada%20a%20Objetos/Docs/Resources/SVRInstallerWINError.png "Svr error")
     
     ![Svr winScree img](https://raw.githubusercontent.com/UCASV/proyecto-final-grupo-35/master/Programacion%20Orientada%20a%20Objetos/Docs/Resources/SVRInstallerWINError2.png "Svr error2")


4. Follow Instalator Steps
    - Database and data required to execute the program will automaticaly be made

    > If you haven´t installed Sql Server 2019 Express this will fail (Go back step 1)
    
5. Run app and login with the given data 
for example: 
    USER: UserTest 
    password: passWord




*Are you looking for the?*
# Documentation

> In the directory 'Programacion Orientada a Objetos/Codigo Fuente/..' will find the proyect source code and the following directory 


    Codigo fuente 
        |-Context
        |-Controls 
        |-Models 
        |-Resources
        |-ViewModels 
        |-Views-|
                |-Appointment Process
                |-Appointment Verification
                |-Vaccination Process
                |-MessageBox

> !!! Dont Modify Context

We used _Microsoft´s EntityFrameworkCore_ as ORM, in order to connect the database named _VaccinationManagementDb_  to Our Proyect, for this porpuse  VaccinationContext.cs file which has all models of the db, provides the context of the DB in the class VaccinationContext, 
Usualy used in code as 

```csharp
var db = new VaccinationContext();
```
> Models files 

In Models directory all the files contains a class that representates a Table created in the DB, and are created and modified for update o insert into DB  for example in Views/AppointmentProcess/AppointmentProcessControls.cs

```csharp
        private void AddOrUpdateCitizenData(){

            var db = new VaccinationContext(); 

                var citizen = new Citizen(
                    Convert.ToInt32(Txbx_DUI.Text),
                    txtb_name.Text,
                    txtbx_addres.Text,
                    Convert.ToInt32(txtbx_phone.Text),
                    txtbx_email.Text,
                    Convert.ToInt32(txtb_ICode.Text),
                    LocationData.GestorId,
                    specialInstitucion.Id,
                    priorityGroup.Id
                );
            db.Citizen.Add(citizen);
            db.SaveChanges();
        }
```

there is a new instance of the [Citizen]() Model then is filled with some data from TextBoxes in the view _AppointmentProcess_, And Added to Database Citizen context, finally added to DB

> ViewModels contains classes for Design Pattern _View Model_ 

In this pattern we transform models and its data from database tables into a View friendly Class which only contains escencial data to show to user for example: 
when you use the AppointmentVM: 
```csharp 
public class AppointmentsVm 
    {
        public int Codigo_Cita { get; set; }
        
        public string DUI { get; set; }
        public string Ciudadano { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public string Tipo_Cita { get; set;}
    }
```

Only has the escencial data for a user to know about




