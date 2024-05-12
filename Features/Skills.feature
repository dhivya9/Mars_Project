Feature: Skills

A short summary of the feature


Background: Clean all skills beforing adding new skills
Given Clean all skills before adding new skills in the list

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
| NewSkill    | Newlevel   |
| 'Music'     | 'Beginner' |
| '243243%^^' | 'Expert'   |

Scenario Outline: C.User able do delete skill record
Given User able to delete the skills and levels they entered on the page<Skills><Levels>
Then  User will get delete notification

Examples: 
| Skills  | Levels     |
| 'Music' | 'Beginner' |

Scenario Outline: User try to add skills as null and levels
Given User try to enter skills filed as Null and levels<Skills><Levels>
Then User see  the Warning notification

Examples: 
| Skills | Levels     |
| ''     | 'Beginner' |
| ''     | ''         |

Scenario Outline: User try add skills without levels
Given User try add skills without levels<Skills>
Then User seethe Warning notification

Examples: 
| Skills  |
| 'Music' |

Scenario Outline: User try to add same skills again
Given User try to add same skills again and again<Skills><Levels>
Then User see the warning message 

Examples: 
| Skills  | Levels     |
| 'Music' | 'Beginner' |
| 'Music' | 'Expert'   |

