# Catalogue
.NET RESTful API with Azure Cosmos DB

<h2> RESTful API .NET Framework 4.7.2 </h2>

Cette API permet les operations suivantes :</br>
• Affichage d'une liste de produits:			 <code>GET</code> <em>api/product</em> </br>
• Affichage des détails d'un produit par ID:	 <code>POST</code> <em>api/product/{id}</em> </br>
• Ajouter un produit au panier:					 <code>POST</code> <em>api/order</em> </br>
• Enlever un produit du panier:					 <code>DELETE</code> <em>api/order/{id}</em> </br>
• Afficher le contenu du panier:				 <code>GET</code> <em>api/order</em> </br>
• Nous utilisons une base de données NoSql <b>AZURE CosmosDB</b> pour le stockage et la recupération des données.</br>

<b>NB :</b> Vous devez indiquer les informations suivantes dans votre fichier <b>web.config</b> pour pouvoir connecter votre API à la Base AZURE CosmosDB:</br>
    < add key="endpoint" value="https://VOTRE-AZURE-HOST.documents.azure.com:443/" /></br>
    < add key="authKey" value="VOTRE-AZURE-AUTHKEY==" /></br>
    < add key="database" value="NOM-DE-VOTRE-DB" /></br>
 
 <b><em>Le Projet Catalogue.Tests doit étre placé au même niveau que le dossier de la solution , comme mentionné dans l'image suivante:</em></b></br>
 ![Alt text](http://ebo.itfingers.net/img/Project&TestProject.png?raw=true "Dossier du projet Tests")

# Captures d'écran des résultats sur Postman:

<b>1- Affichage d'une liste de produits</b> 

![Alt text](http://ebo.itfingers.net/img/ListeDesProduits.png?raw=true "Résultats liste des produits")


<b>2- Affichage des détails d'un produit par ID</b> 

![Alt text](http://ebo.itfingers.net/img/ProductByIdx.png?raw=true "Affichage du produit par Id")

<b>3- Ajouter un produit au panier</b> 

![Alt text](http://ebo.itfingers.net/img/PlaceOrder.png?raw=true "Ajouter un produit au panier")

<b>4- Enlever un produit du panier</b> 

![Alt text](http://ebo.itfingers.net/img/RemoveOrder.png?raw=true "Enlever un produit du panier")


<b>4- Afficher le contenu du panier</b> 

![Alt text](http://ebo.itfingers.net/img/DisplayOrders.png?raw=true "Afficher le contenu du panier ")
