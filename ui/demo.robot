*** Settings ***
Library   SeleniumLibrary
Test Teardown   Close Browser

*** Test Case ***
Number of product(s) must be 2
    Open demo page
    Product should have 2

*** Keywords ***
Open demo page
    Open Browser   http://localhost:9000/api/values  browser=chrome

Product should have 2
    Page Should Contain   CTP20