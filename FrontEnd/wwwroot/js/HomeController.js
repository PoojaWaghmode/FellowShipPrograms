    // --------------------------------------------------------------------------------------------------------------------
    // <copyright file="HomeController.js" company="Bridgelabz">
    // Copyright © 2019 Company
    // </copyright>
    // <creator name="Pooja Waghmode"/>
    // --------------------------------------------------------------------------------------------------------------------

    ////This is Javascript file 


    ////function loadData() is  for Load data in table which comes from server 

    function loadData() {

            /////Here We use  jquery with ajax 
        $.ajax(
            {

                ////Here we load the data from server i.e API 
                url: "https://localhost:44324/api/Employee/getAllEmployee",

                ////Here we set type as Get because we get data from API
                type: "GET",

                 ////Here we set contentType as json i.e we get data in json format
                contentType: "application/json;charset=utf-8",
                dataType: "json",

                ////Here we have result and that result is store in table
                success: function (result) {

                    ////This will show the all data on browser console which holds in object array
                    console.log(result);

                    ////Here i will display all data in table format
                    var html = '';

                    ////Here item holds the all data of every employee
                    $.each(result, function (key, item) {

                        ////here every item have data so it will print
                        $.each(item, function (key, data) {
                            html += '<tr>';
                            html += '<td>' + data.employeeId + '</td>';
                            html += '<td>' + data.firstName + '</td>';
                            html += '<td>' + data.lastName + '</td>';
                            html += '<td>' + data.address + '</td>';
                            html += '<td>' + data.email + '</td>';
                            html += '</tr>';
                        });
                    });
                    ////here it will concat all data to table body
                    $('.tbody').html(html);
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
    }

        //// here function Add() is used to insert and store data of employee in database 
         function Add() {
             var res = validate();
             if (res == false)
             {
                 return false;
             }
            ////Here we creates the javascript object employee 
            var employee= {
       
                FirstName : $("#firstName").val(),
                LastName : $("#lastName").val(),
                Address : $("#address").val(),
                Email: $("#email").val()
        
            }; 
            $.ajax({

                 ////Here we give the path of server from where we will insert data 
                url: "https://localhost:44324/api/employee/add",

                ////Here stringify ()method converts the javascript object or value to json string
                data: JSON.stringify(employee),

                ////Here we use the post to insert data
                type: "POST",

                ////Here we use the json format
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function ()
                {
                    ////After adding data alert() function which will show() the message
                    alert("Successfully added.....");
                },
                error: function (errormessage)
                {
                    ////If any error occurs then it will throw error message 
                    alert(errormessage.responseText);
                }
            });
        }

    //// here function update() is used to update data of employee in database 
    function Update() {

        ////Here we creates the javascript object employee 
        var employee = {

            EmployeeId: $("#employeeId").val(),
            FirstName: $("#firstName").val(),
            LastName: $("#lastName").val(),
            Address: $("#address").val(),
            Email: $("#email").val()

        };
        $.ajax({

            ////Here we give the path of server from where we will insert data 
            url: "https://localhost:44324/api/Employee/update",

            ////Here stringify ()method converts the javascript object or value to json string
            data: JSON.stringify(employee),

            ////Here we use the PUT to update data
            type: "POST",

            ////Here we use the json format
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result)
            {
                console.log(result);
                loadData();
                EmployeeId: $("#employeeId").val("");
                FirstName:  $("#firstName").val("");
                LastName:  $("#lastName").val("");
                Address:   $("#address").val("");
                Email:     $("#email").val("");

                ////After adding data alert() function which will show() the message
                alert("Successfully Updated....");

            },
            error: function (errormessage)
            {
                ////If any error occurs then it will throw error message 
                alert(errormessage.responseText);
            }
        });
    }

////function validate() gives validation to fields

function validate() {

    var isValid = true;
    if ($('#firstName').val().trim() == "")
    {
        $('#firstName').css('border-color', 'Red');
       isValid = false;
    }
    else
    {
        $('#firstName').css('border-color', 'lightgrey');
    }
    if ($('#lastName').val().trim() == "")
    {
        $('#lastName').css('border-color', 'Red');
        isValid = false;
    }
    else
    {
        $('#lastName').css('border-color', 'lightgrey');
    }
    if ($('#address').val().trim() == "")
    {
        $('#address').css('border-color', 'Red');
        isValid = false;
    }
    else
    {
        $('#address').css('border-color', 'lightgrey');
    }
    if ($('#email').val().trim() == "")
    {
        $('#email').css('border-color', 'Red');
        isValid = false;
    }
    else
    {
        $('#email').css('border-color', 'lightgrey');
    }
    return isValid;

}
