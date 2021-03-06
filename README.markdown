# Scutex

Scutex, pronounced (sec-u-techs), is a 100% managed .Net Framework licensing platform for your applications. Scutex is a flexible licensing system allowing multiple licensing schemes allowing you the most control over how you licensing your products. Unlike any other licensing system on the market, Scutex provides 4 distinct licensing schemes, allowing you to protect your products at different levels using completely different licensing schemes, key types and protection systems.

Using Scutex you can create trial versions of your software products and allow your users to buy and use license keys or keyfiles to unlock your product. You can also have edition based licensing to unlock only select features based on the level of the license. Scutex supports upgrade licenses as well as allowing your customers who have an existing version of your product to upgrade to a new version.

## License

Licensed under the Microsoft Public License (MS-PL)

## Resources

* **WaveTech's Home page:** <http://www.wtdt.com>
* **Scutex's Home Page:** <http://www.wtdt.com/Products/Scutex.aspx>
* **Forum:** <http://www.wtdt.com/Support/Forums/tabid/79/afg/9/Default.aspx>
* **JIRA:** <http://jira.wtdt.com:8080/browse/SCUTEX>
* **Discussion list:** <http://groups.google.com/group/scutex-dev>

## Infragistics Components

Currently Scutex uses Infragistics WPF v10.3 components inside the Management project. The Managment project is the main UI interface when working with a licening scheme and product. Although this dependency is being reworked to allow for everyone to build the projects this is currently not the case.  You can install a trial version of Infragistics WPF components and relink the references or if you already have Infragistics WPF installed you can just relink to your installed version. Any of the v10 versions of the Infragistics WPF components should work, you will just need to update the XAML headers with the new DLL name and namespace.

## Official Builds & Releases

There are a number of additional processes that occur for preparing Scutex to be used in your applications. Because of that there is only one place to obtain official builds that you should install and use in your products. To obtain official builds just got to the Scutex homepage at http://www.wtdt.com/Products/Scutex.aspx and click on the Downloads link. Official release builds will be a big bold download link and you can get access to development builds from our CI server.

## Prerequisites

You will need the .Net Framework 4 and SQL Server or SQL Express to use Scutex. 