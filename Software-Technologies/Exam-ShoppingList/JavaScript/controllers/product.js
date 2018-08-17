const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find().then(products => {
            res.render('product/index', {'products': products});
        });
	},
	createGet: (req, res) => {
        res.render('product/create');
	},
	createPost: (req, res) => {
        let productArgs = req.body;

        if (productArgs.priority === undefined || productArgs.name === undefined
				|| productArgs.quantity === undefined || productArgs.status === undefined) {
            res.redirect('/');
            return;
        }

        Product.create(productArgs).then(product => {
            res.redirect('/');
        });
	},
	editGet: (req, res) => {
        let id = req.params.id;

        Product.findById(id).then(product => {
            if (product) {
                return res.render('product/edit', product);
            }
            else {
                return res.return('/');
            }
        });
	},
	editPost: (req, res) => {
        let id = req.params.id;
        let product = req.body;

        Product.findByIdAndUpdate(id, product, {runValidators:true}).then(products => {
            res.redirect('/');
        });
	}
};