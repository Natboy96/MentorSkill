Feature: MentorSkidSignUp

AAs a user on MentorSkid website
I want tp signup so that I cab be a register mentor

@tag1
Scenario: Verify a successful signup on MentorSkid
	Given I am a user on MentorSkid website
	When I click on signup button
	And I enter a valid first name "VanDam"
	And I enter a valid last name "Lamba"
	And I enter a valid email address "VanDam@outlook.com"
	And I enter a valid password "Password1234"
	And I click on the radio button 
	And I click on the checkbox for Terms and conditions
	And I click on the join now button
	Then A successful message is displayed
