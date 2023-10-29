@Code
    ViewData("Title") = "Index"
End Code


<script type="text/javascript">

    function myDialog() {
        let text = "Press a button!\nEither OK or Cancel.";
        if (confirm(text) == true) {
            text = "You pressed OK!";
        } else {
            text = "You canceled!";
        }
        document.getElementById("presponse").innerHTML = text;
    }

</script>

<div class="modal fade" id="myModal">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Modal Dialog  Box
            </div>
            <div class="modal-body">
                <p>This is a modal dialog box</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="row">

    <div class="jumbotron col-md-6 ">
        <h2 class="px-2">Jumbotron 1</h2>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
        <p><a href="https://asp.net" class="btn btn-primary btn-sm">Learn more &raquo;</a></p>
    </div>
    
    <div class="jumbotron col-md-6 px-2">
        <h2>Jumbotron 2</h2>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
        <p><a href="https://asp.net" class="btn btn-primary btn-sm">Learn more &raquo;</a></p >
    </div>

</div>

    <div class="row">
        <div class="col-md-4">
            <h2>One</h2>
            <p>Content of One.  <a href="#" class="btn btn-primary btn-sm" onclick="$('#myModal').modal('show');">Modal Dialog Box</a> </p>
        </div>
        <div class="col-md-4">
            <h2>Two</h2>
            <p>Content of Two <a href="#" class="btn btn-primary btn-sm" onclick="myDialog();">Confirm Modal Dialog Box</a> </p>
            <p id="presponse"></p>
        </div>
        <div class="col-md-4">
            <h2>Three</h2>
            <p>Content of Three</p>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Four</h2>
            <p>Content of Four</p>
        </div>
        <div class="col-md-4">
            <h2>Five</h2>
            <p>Content of Five</p>
        </div>
        <div class="col-md-4">
            <h2>Six</h2>
            <p>Content of Six</p>
        </div>
   

