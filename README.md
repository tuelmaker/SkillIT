# SkillIT

This project is intended to allow the automated download of skills matching a prescribed set of jobs based on a search URL within LinkedIn. Furthermore, the returned data will be in the form of the JobInformationModel via the Extractor as JSON.
Secondly, there is a parser element to this project which will allow you to load the JSON and parse it so that you get a flattened version of the JobSkillModel as a csv which you can then open in Excel and create a Pivot table from.

# Usage

In order to use this project you will need to have a LinkedIn account and access to the LinkedIn premium features which enables the skills comparison lookup. 
Initial URL is based on specific criteria, but you are free to change it to whatever search works for you.
![image](https://github.com/tuelmaker/SkillIT/assets/30091037/f7d6e852-9cb5-496d-ab55-88dcedcaba51)


Use the parser tool to load the JSON and flatten it.
![image](https://github.com/tuelmaker/SkillIT/assets/30091037/57c3be32-6484-48be-93ba-8f231308d8a7)


Example of parser output.

![image](https://github.com/tuelmaker/SkillIT/assets/30091037/c4503dcb-8d11-4394-8b4f-bb813bdc33ee)

Here is an example of the JSON once we run it through the SkillIT Parser. You can used as-is or within a pivot table to get more refinement.
[Jobs_Flattened_small.csv](https://github.com/tuelmaker/SkillIT/files/13492967/Jobs_Flattened_small.csv)
