const express = require("express");
const router = express.Router();

//importing services
const Validator = require("../services/validators");
const DbContext = require("../services/db");

//new instances of classes
const dbc = new DbContext();
const dbcBlogs = new DbContext();
const v = new Validator();

//setting a database file that should be used
dbc.useCollection("users.json");
dbcBlogs.useCollection("blogs.json");

let signedUser = {};

router.get("/up", (req, res) => {
	res.render("sign-up");
});

router.post("/up", (req, res) => {
	if (v.isValidUser(req.body)) {
		dbc.signUp(
			req.body,
			() => res.render("sign-up", { success: true }),
			() => res.render("sign-up", { exists: true })
		);
	} else {
		res.render("sign-up", { error: true, success: false });
	}
});

router.get("/in", (req, res) => {
	res.render("sign-in");
});

router.post("/in", (req, res) => {
	setUser();
	if (v.isValidUser(req.body)) {
		dbc.signIn(req.body, (user) => {
			if (user) {
				setTimeout(() => {
					res.redirect("/profile");
				}, 500);
			} else if (user == false) {
				res.render("sign-in", { incorrect: true });
			}
		});
	} else {
		res.render("sign-in", { error: true });
	}
});

router.get("/out", (req, res) => {
	setUser();
	let blogs = [];
	dbcBlogs.getAll((records) => {
		blogs = records;
	});
	dbc.signOut(() =>
		setTimeout(() => {
			res.redirect("/");
		}, 500)
	);
});

//identifying a signed user
const setUser = () => {
	dbc.checkUser((user) => {
		signedUser = user;
	});
};

module.exports = router;