Feature: Skills

A short summary of the feature

@tag1
Scenario Outline: A.User able to enter their known skills and levels
Given User able to enter their known skills<Skills>
Then User able to enter their skill levels<Levels>
And validate skills and levels are added correctly<Skills>

Examples: 
| Skills          | Levels         |
| 'Communication' | 'Expert'       |
| 'Behavioural'   | 'Intermediate' |
| 'Dancing'       | 'Beginner'     |

Scenario Outline: B.User able to Edit skills and levels
Given User able to Edit the Skill field<NewSkill>
Then User able to Edit the levels field<Newlevel>
And Validate Skills and levels field are updated correctly<NewSkill>

Examples: 
| NewSkill | Newlevel   |
| 'Music'  | 'Beginner' |

Scenario: C.User able do delete skill record
Given User able to delete the skills and levels they entered on the page