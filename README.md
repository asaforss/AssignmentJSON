# AssignmentJSON

Assignment

Create a function that returns a JSON-structure for delivery dates. Example output can be found below at the end of this description.


The function should take a postal code and a product list as input.


The format for the product list is up to you to define, but it should include the following properties:


- productId
- name
- deliveryDays (a list of weekdays when the product can be delivered)
- productType (normal, external or temporary)
- daysInAdvance (how many days before delivery the products need to be ordered)


Logic


The function should return the available delivery dates for the upcoming 14 days. Calculations should be made from current date when code runs.


The following restrictions apply:


- a delivery date is not valid if a product can't be delivered on that weekday
- a delivery date is not valid if a product must be ordered more days in advance than possible
- all external products need to be ordered 5 days in in advance
- temporary products can only be ordered within the current week (Mon-Sun)


The result should be sorted in priority order, with green delivery dates at the top of the list if they are within the next 3 days, otherwise dates should just be sorted ascending.


Limitations and guidelines


- Use the programming language and editor of your choice
- No storage is needed
- It should be possible to execute the code in some way


When demonstrating your solution, be prepared to navigate through the code and execute it.


Example output:


{
 "status": "success",
 "data": {
   "deliveryDates": [
     {
       "postalCode": 13756,
       "deliveryDate": "2019-02-12T00:00:00+01:00",
       "isGreenDelivery": false
     },
     {
       "postalCode": 13756,
       "deliveryDate": "2019-02-13T00:00:00+01:00",
       "isGreenDelivery": true
     }
   ]
 }
}

Hej!

Klistrar in uppgiften. Delar av den är - medvetet - lite luddig och då är det helt ok att ta egna beslut och/eller att hoppa över någon del (redogör gärna för detta i så fall). Poängen med uppgiften är som sagt struktur och läsbarhet snarare än en optimal lösning. Vet inte hur mycket erfarenhet du har av enhetstester, men det är ingen nackdel i sammanhanget i alla fall ;-)

Hör av dig när du har en lösning och dela den gärna via länk till Github
