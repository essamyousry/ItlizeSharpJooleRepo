

        $(document).ready(function () {
            $(function () {
                for (var i = 0; i < @Model.SpecFilterList.Count; i++) {
                    createSlider(i);
                }
            });
        });

        function createSlider(i) {
            $("#" + i).slider({
                range: true,
                min: parseInt($('#min_' + i).val()),
                max: parseInt($('#max_' + i).val()),
                values: [25, 75],
                slide: function (event, ui) {
                    $("#a_" + i).val(ui.values[0]);
                    $("#b_" + i).val(ui.values[1]);
                }
            });
            $("#a_" + i).val($("#" + i).slider("values", 0));
            $("#b_" + i).val($("#" + i).slider("values", 1));
        }

        function sendValues() {
            var year1 = $('#year1').val();
            var year2 = $('#year2').val();
            var values = {};

            for (var i = 0; i < @Model.SpecFilterList.Count; i++) {
                values[$('#name_' + i).val()] = $('#a_' + i).val().toString() + '-' + $('#b_' + i).val().toString();
            }
            //alert(JSON.stringify(values));
            $.ajax({
                url: '/Results/GetProducts/',
                data: { Year1: year1.toString(), Year2: year2.toString(), filter: JSON.stringify(values), subid: @Model.SubCategoryID.ToString() },
                type: "POST",
                dataType: "JSON",

                success: function (data) {
                    window.location.href = data.url;
                }
            })

        }

        function clearData() {

            $('#year1').val('');
            $('#year2').val('');
            for (var i = 0; i < @Model.SpecFilterList.Count; i++) {
                createSlider(i);
            }
        }

        function showDetails(id) {
            var prodid = id.substr(5);
            //alert(prodid);

            $.ajax({
                url: '/Product/getProductID/',
                data: { prodid: prodid },
                type: "POST",
                dataType: "JSON",

                success: function (data) {
                    window.location.href = data.url;
                }
            })

        }

        function compare() {
            var arr = [];
            $.each($("input[name='prod']:checked"), function () {
                var prodid = ($(this).attr('id')).substr(6);
                arr.push(prodid);
            });

            //alert(arr.toString());

             $.ajax({
                url: '/Product/Compare/',
                data: {prod1: arr[0], prod2: arr[1]},
                type: "POST",
                dataType: "JSON",

                success: function (data) {
                    window.location.href = data.url;
                }
            })

        }
