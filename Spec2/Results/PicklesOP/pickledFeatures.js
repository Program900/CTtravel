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
              "WasExecuted": false,
              "WasSuccessful": false
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
              "WasExecuted": false,
              "WasSuccessful": false
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
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
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
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Honeymoon Holidays",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Opera Holidays",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Rail Holidays",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Ranch Holidays",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "River Cruises",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Route 66",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Self Drive Holidays",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
                      }
                    ],
                    [
                      "Short Breaks",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false
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
              "WasExecuted": false,
              "WasSuccessful": false
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
              "WasExecuted": false,
              "WasSuccessful": false
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
              "WasExecuted": false,
              "WasSuccessful": false
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
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@mytag",
        "Total": 2,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 2
      }
    ],
    "Folders": [
      {
        "Folder": "ChooseDestination.feature",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
      },
      {
        "Folder": "ChooseYourHoliday.feature",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
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
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 6
    },
    "Features": {
      "Total": 2,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 2
    }
  },
  "Configuration": {
    "SutName": "CTTRAVLETEST",
    "SutVersion": "1.0",
    "GeneratedOn": "6 August 2018 18:56:48"
  }
});