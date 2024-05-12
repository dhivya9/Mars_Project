Feature: Mars

A short summary of the feature

Background: Clean all data before adding new data
Given Delete all before adding new langauge



Scenario Outline:  A.User able to enter the known languages and levels
Given user able to enter their language<language1><language2><language3><language4> and levels
Then verify user can able add more than four values

Examples: 
| language1 | language2   | language3 | language4 |
| 'Tamil'   | 'Telugu'  | 'English' | 'French' |


 Scenario Outline: B.User able to update the language and levels
 Given User able to edit the language filed<newlanguage><levels>
 Then  verify the both fields update successfully

 Examples: 
 | newlanguage | levels  |
 | 'German'    | 'Basic' |
 

 Scenario Outline:C.User able to delete the record
Given User able to delete the record<Deletelanguage><levels>
 Examples: 
 | Deletelanguage | levels  |
 | 'Italy'        | 'Basic' |

Scenario Outline: D.User try to Add langauge without levels
Given User able to add the language and levels as null<Addlanguage>
Then User able to see Error notification

Examples: 
| Addlanguage | 
| 'Japanese'  | 
 
 Scenario Outline:E.User able to Enterlangauge with Special Character
 Given User able to enter lanaguges  with Special Character<Speciallanguage>

 Examples: 
 | Speciallanguage |
 | '#$%^&*  '      |
 

 Scenario: F.User able to add langauge as null and levels
 Given User able to add language as null <Languages><levels>
 Then User see the warning message

 Examples: 
 | Languages | levels   |
 | ''        | 'Fluent' |
 | ''        | ''       |

 Scenario Outline: G.User try to add same langauge again
 Given User try to add same langauge twice<Languages><levels>
 Then User able to see the warning notification
 Examples: 
 | Languages | levels   |
 | 'English' | 'Fluent' |
 
