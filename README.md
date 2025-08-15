**INTRODUCTION**  
This repository is intended to store code for learning fundamental C# concepts and skills. It also serves as a practice
space for version control using Git and GitHub, including changelog management.

**HOW TO USE git-changelog built with Node.js**

1. If capable, you can update the installation tool npm initially, by running the following command
   `npm install -g npm@x.x.x`, where x.x.x is your target npm version. You can then verify the installed npm version in
   Rider by running `npx npm --version` or `npm -v`.
2. Use `git-changelog` (Node.js) to manage your changelog.
3. Install `git-changelog` using the following command `npm install -g git-changelog` in your terminal. You can also
   verify the installed git-changelog version in Rider by running `git-changelog --version`.
4. If you want to use the `git-changelog` tool in Rider to generate a changelog automatically, you must add a
   configuration file in the root of your repository. The file should be named `.changelogrc`. You can find an example
   of this file in the repository.
5. To generate a changelog automatically, you can run the command `git-changelog` in your terminal. This will create a
   `CHANGELOG.md` file in the root of your repository based on the configuration in the `.changelogrc` file.
6. The `CHANGELOG.md` file will be updated automatically each time you run the `git-changelog` command.
7. The `CHANGELOG.md` is generated using ** the default template**. To change its format, customise the `template.md`
   and `commit_template.md` files inside the `templates` directory.
8. If you want to know more about the `git-changelog` tool, you can check the
   official [documentation](https://github.com/rafinskipg/git-changelog).