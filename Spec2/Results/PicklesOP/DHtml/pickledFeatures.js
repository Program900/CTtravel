jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "ChooseDestination.feature",
      "Feature": {
        "Name": "ChooseDestination",
        "Description": "In order to search for a Destination\r\nAs a Leisure Travel\r\nI want to Choose Destination",
        "FeatureElements": [
          {
            "Name": "Count Destination",
            "Slug": "count-destination",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HomePage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have  ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see '38' Destination",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@mytag"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "Options  Destination",
            "Slug": "options-destination",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HomePage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have  ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see OptionsOfDestinationCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "Choose Destination",
            "Slug": "choose-destination",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HomePage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have  ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I select any ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see selected ChooseyourDestination",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "ChooseYourHoliday.feature",
      "Feature": {
        "Name": "ChooseYourHoliday",
        "Description": "In order to Travel in Holidays\r\nAs a Leisure Travel user\r\nI want to choose a Holiday Collection",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Holiday"
                  ],
                  "DataRows": [
                    [
                      "Family Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Honeymoon Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Opera Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Rail Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Ranch Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "River Cruises",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Route 66",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Self Drive Holidays",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "Short Breaks",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "select  Holiday Collection",
            "Slug": "select-holiday-collection",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HolidayCollections",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have ChooseAHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click on '<Holiday>'",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@mytag"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "Count Holiday Collection",
            "Slug": "count-holiday-collection",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HolidayCollections",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have ChooseAHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see '10' HolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "Options of Holiday Collection",
            "Slug": "options-of-holiday-collection",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on HolidayCollections",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have ChooseAHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on ChooseHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see OptionsofHolidayCollection",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Background": {
          "Name": "HolidayCollections",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I am on HomePage",
              "StepComments": [],
              "AfterLastStepComments": []
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "I open HolidayCollections",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@mytag",
        "Total": 2,
        "Passing": 2,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "ChooseDestination.feature",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "ChooseYourHoliday.feature",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "ChooseDestination.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "ChooseYourHoliday.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 6,
      "Passing": 6,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 2,
      "Passing": 2,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "SutName": "CTTravel",
    "SutVersion": "1.0",
    "GeneratedOn": "6 August 2018 18:49:07"
  }
});