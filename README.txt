There are 3 Programs, in the solution

FinancialInstructionNet
=======================
The Web API which receives the Instructions for Sales and Purchases

ClientTestApp
=============
A Test app to allow the ability to send test instructions to the Financial Instruction Net

USDReportingTool
================
A console app which displays the folloing reports by querying the Web API
1. Amount in USD settled incoming everyday
2. Amount in USD settled outgoing everyday
3. Ranking of entities based on incoming and outgoing amount e.g. if entity foo
   instructs the highest amount for a buy instruction, then foo is rank 1 for outgoing