$("#btnDangKy").click(function (e) {
	e.preventDefault();
	var madetai = $("#btnDangKy").attr("name");
	//alert("abc");
	$.post("/SinhVien/DangKyDeTai",
		{
			MaSinhVien: "17045611",
			MaDeTai: madetai
		},
		function (data, status) {
			//alert("Data: " + data + "\nStatus: " + status);
			if (status == "success") {
				var select = "#" + madetai + " " + ".capnhatsoluong";
				$(select).text(data);
			}
			else {
				alert(data);
			}
		});
});