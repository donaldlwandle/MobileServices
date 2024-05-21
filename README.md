
# MobileServices
#### Mobile Services aim to address the unemployment crisis in South Africa, particularly among the youth. This is achieved through an information system that provides a platform as a windows desktop applicaton for individuals with verified skills and qualifications to showcase their freelance services. Potential customers within a chosen radius can use the platform to find and request the services they need.

## UI Preview:
<img width="95%" src="https://drive.google.com/thumbnail?id=1unwHLIjDVmbdbOcGKmr_vG8vmpYSxSUa&sz=w1000" />
<img width="95%" src="https://drive.google.com/thumbnail?id=148DX_e2OBBgg9BgnHHb04qRMe9-ePrLZ&sz=w1000"/>

## System Architecture:
#### I have built The application following a <a href="https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html" target="_blank">Clean Architecture</a> design phillosophy by <a href="http://cleancoder.com/products" target="_blank">@Uncle Bob martin</a> to bring about separation of concerns between the Business logic layer and  the Presentation layer to allow for high Perfomance, Maintanability and  Testibility.

<img width="95%" src="https://drive.google.com/thumbnail?id=1798xH1Oexdi_FggIjq1P1HJx56Pegku2&sz=w1000" />




## Functionality:
#### <ins>Customer Side</ins>
<ol>
  <li>
    Home Page Display:
    <ul>
      <li>When the system launches, the home page will display a random list of all available services from the database.</li>
    </ul>
    
    
  </li>

  <li>
    Service Selection and User Authentication:
    <ul>
        <li>When a customer clicks on a service item, the system will prompt them to register or log in, depending on whether they already have an account.</li>
        <li>If the customer chooses to log in, they must provide an email and password.</li>
        <li>If the customer does not have an account, they must register. Registration requires entering name, surname, phone number, email, password, WhatsApp number (optional), city or town, and physical address.</li> 
  </ul>
    
    
  </li>

  <li>
    Post-Registration Experience:
    <ul>
      <li>After registration, the system will display services available in the user's area on the home panel.</li>
      <li>The user can search for services by title, location, or name.</li>
    </ul>
    
    
  </li>

  <li>
     Order Notifications:
    <ul>
        <li>Upon successful order completion, a notification will be sent to the service provider, and the customer will receive a notification regarding the status of their order.</li>
       
  </ul>

  <li>
     Profile Management:
    <ul>
        <li>When the user clicks on the profile icon, the system will display the profile page, where the user can view and update their profile.</li>
       
  </ul>

  <li>
     Order Management:
    <ul>
        <li>When the user clicks on the "My Orders" button, the system will display the orders page, where the user can view requested orders and their status (pending or accepted).</li>
       
  </ul>
</ol>

#### <ins>Service Provider Side</ins>
<ol>
  <li>
    Default Registration:
    <ul>
      <li>By default, users are registered as customers.</li>
    </ul>
    
    
  </li>

  <li>
    Service Provider Registration:
    <ul>
        <li>Users can opt to register as service providers.</li>
        <li>The system will prompt the user with a registration form to register as a service  provider.</li> 
  </ul>
    
    
  </li>

  <li>
    Main Page Navigation:
    <ul>
      <li>The main page UI navigation panel will include a "Completed" button, launching a page that shows accepted services, and a "My Services" panel, where the service provider can view and add new services.</li>
    </ul>
    
    
  </li>

  <li>
    Adding New Services:
    <ul>
        <li>When creating a new service, the user will be prompted with a form to provide the service information.</li>
       
  </ul>
</ol>




## About the project:
I have built this application with <a href="https://github.com/facebook/create-react-app](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481" target="_blank">.NET 4.8 Framework</a> as a base.

#### <ins>Develpment tools:</ins>

<ol>
  <li>
    Frameworks:
    <ul>
      <li> .Net Framework: Development enviroment.</li>
    </ul>
    
    
  </li>

  <li>
    Libraries:
    <ul>
      <li>WinForm Library : For user interface </li>
      <li>Google Cloud Library : For creating a remote SQL instance to connect different devives to a backend SQL DBMS for testing purposes</li>
      <li>MySQL server Data tools : For connecting the application to  MySQL tools</li>
    </ul>
    
  </li>

  <li>
    Database:
    <ul>
      <li>MySQL Workbench: for integrating SQL development, administration, database design and creation of the database </li>
    </ul>
    
  </li>

  <li>
    Programming Languages:
    <ul>
      <li>C#: for building the application  business logic and the user interface.</li>
      <li>SQL: for building the system's backend database queries.</li
    </ul>
    
  </li>

</ol>








