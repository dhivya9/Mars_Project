Feature: Feature1

A short summary of the feature

Scenario:User able to login in Mars portal
Given User able to login with valid cerdentials


Scenario Outline: User able to login in Mars portal with invalid Cerdentials
Given User try to login with invalid EmailID<Email_ID><Password>

Examples: 
| Email_ID           | Password    |
| 'dhivya@gamkil.com' | 'dhivya1' |