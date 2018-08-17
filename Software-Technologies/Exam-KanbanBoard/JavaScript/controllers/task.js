const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
        Task.find().then(tasks => {
            res.render('task/index', {
            	'openTasks': tasks.filter(t => t.status === "Open"),
                'inProgressTasks': tasks.filter(t => t.status === "In Progress"),
                'finishedTasks': tasks.filter(t => t.status === "Finished")
			});
        });
	},
	createGet: (req, res) => {
        res.render('task/create');
	},
	createPost: (req, res) => {
        let taskArgs = req.body;

        if (taskArgs.title === undefined || taskArgs.status === undefined) {
            res.redirect('/');
            return;
        }

        Task.create(taskArgs).then(task => {
            res.redirect('/');
        });
	},
	editGet: (req, res) => {
        let id = req.params.id;

        Task.findById(id).then(task => {
            if (task) {
                return res.render('task/edit', task);
            }
            else {
                return res.return('/');
            }
        }).catch(err => res.redirect('/'));
	},
	editPost: (req, res) => {
        let id = req.params.id;
        let task = req.body;

        Task.findByIdAndUpdate(id, task, {runValidators:true}).then(tasks => {
            res.redirect('/');
        }).catch(err => {
            task.id = productId;
            task.error = 'Cannot edit task.';
            return res.render('task/edit', task);
        });
	}
};