Feature: Feature1

A short summary of the feature

Scenario:A.User able to login in Mars portal
Given User able to login with valid cerdentials


Scenario Outline:B. User try to login in Mars portal with invalid username and password
Given User try to login with invalid EmailID<Email_ID><Password>

Examples: 
| Email_ID                 | Password   |
| 'dhivya@gamkil.com'      | 'dhivya1'  |

Scenario Outline:C. User try to login with valid username and invalid password
Given user try to login with valid username and invalid password<Email_ID><Password>
Then User will get Error Notification

Examples: 
| Email_ID                  | Password |
| 'dhivyaglitz23@gmail.com' | '1234#$' |
| 'dhivyaglitz23@gmail.com' | ''       |

Scenario Outline: D.User try to login with invalid username and valid password
Given User try to login with invalid username and valid password<Email_ID><Password>
Then User will see the warning notification in Email field
Examples: 
| Email_ID  | Password     |
| '1234%^&' | 'Dhivya@23'  |
| ''        | 'Dhivya@23 ' |

Scenario Outline: E.User try to login when both the fields are empty
Given User keep both username and password field empty and click on Login <Email_ID><Password>
Then User will see the warning in username field
Then user will see the warning in password field
Examples: 
| Email_ID | Password |
| ''       | ''       |




