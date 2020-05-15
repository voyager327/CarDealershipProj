"use strict"


function survey(answers){
    let surveyStarter = promptFor("Welcome to our Buying and Selling Webapp." + "\n" + "If you know what kind of car you are looking for then be our guest look around for what you like." + "\n" + "However if you are unsure of what you might like we encourage you to take our survey that will give you stlyes as well as vehicles that we think you might like based on your needs." + "\n" + "Would you like to take our survey? Please enter 'yes' or 'no'", yesNo).toLocaleLowerCase();
    let surveyStarterAnswer;
    let surveyStarterDenied; 
    switch(surveyStarter){
        case 'yes':
            surveyStarterAnswer = firstQuestion(answers);
        break;
        case 'no':
            surveyStarterDenied = breakout();
        break;
        default:
            survey(answers); // restart the app
        break;
    }
}

function firstQuestion(answers){
    let questionOne = promptFor("What is your primary reason for looking to purchase this vehicle?" + "\n" + "Is it for Work?(i.e. towing, hauling, plowing, ect." + "\n" + "Is it for Casual usage?(i.e. running errands, picking up groceries, ect.)" + "\n" + "Is it for Business/Luxuary? (i.e. bussiness excutive, high quality, afforadable luxuary class, ect.)" + "\n" + " Is this for Fun/Recreational (i.e. camping, kayaking, wall crawling, ect.)"+ "\n" + "Is this to be better for the enviroment?(i.e. would you like an electric vehicle, something with lower emmissions)" + "\n" + " Please enter 1, 2, 3, 4, or 5", chars);
    let firstQuestionAnswer;
    if (vehicle.reason === questionOne){
        switch(reason){
            case '1': //"Is it for Work?(i.e. towing, hauling, plowing, ect."
                firstQuestionAnswer = secondQuestion(answers);
            break;
            case '2': //"Is it for Casual usage?(i.e. running errands, picking up groceries, ect.)"
                firstQuestionAnswer = thirdQuestion(answers);
            break;
            case '3': //"Is it for Business/Luxuary? (i.e. bussiness excutive, high quality, afforadable luxuary class, ect.)"
                firstQuestionAnswer = fourthQuestion(answers);
            break;
            case '4': //" Is this for Fun/Recreational (i.e. camping, kayaking, wall crawling, ect.)"
                firstQuestionAnswer = fifthQuestion(answers);
            break;
            case '5': //"is this to be better for the enviroment?(i.e. would you like an electric vehicle, something with lower emmissions)
                firstQuestionAnswer = sixthQuestion(answers);
            default:
                firstQuestion(answers); // re ask the question 
            break;
        }
        return secondQuestionAnswer;

    }
    else{
        return breakout();
    }

}

function secondQuestion
}

function secondQuestion(answers)
let questionTwo = promptFor("Would you like more power, or more versatility?" + "\n" + "Please enter 1 for more power, or 2 for more versatility." , chars);
let secondQuestionAnswer;
switch(questionTwo){
    case '1':
        secondQuestionAnswer = seventhQuestion(answers)
    break;
    case '2':
        secondQuestionAnswer = eighthQuestion(answers)
    break;
    default:
        secondQuestion(answers); // re ask the question 
    break;
}

function thirdQuestion(answers)















// function that prompts and validates user input
function promptFor(question, valid){
    do{
      var response = prompt(question).trim();
    } while(!response || !valid(response));
    return response;
  }
  
  // helper function to pass into promptFor to validate yes/no answers
  function yesNo(input){
    return input.toLowerCase() == "yes" || input.toLowerCase() == "no";
  }
  
  // helper function to pass in as default promptFor validation
  function chars(input){
    return true; // default validation only
  }
  