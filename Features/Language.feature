Feature: Mars

A short summary of the feature
Scenario Outline:  A.User able to enter the known languages and levels
Given User able to signin the Mars portal
When user able to enter their language<language1><language2><language3><language4>
Then  verify user can able add more than four values

Examples: 
| language1 | language2   | language3 | language4 |
| 'Tamil'   | 'Telugu'  | 'English' | 'French' |


 Scenario Outline: B.User able to update the language and levels
 Given User able to edit the language filed<newlanguage>
 When User able to edit the levels<levels>
 Then  verify the both fields update successfully

 Examples: 
 | newlanguage | levels  |
 | 'German'    | 'Basic' |
 
 Scenario:C.User able to delete the record
 Given User able to give cancel from edit 
 Given User able to delete the record
 
 