# FirePrepKitMobile

FirePrepKitMobile is a mobile Unity app that makes fire safety planning easy and fun. Optionally, should you opt-in for this segment of the service, your pre-incident plan can be sent to emergency responders in advance.

## Features

- Interactive, fun fire safety checklist game
- Collect points and redeem them for prizes like up to 20% off your home insurance policy
- Automatic floorplan generation: use your phone to scan your home in minutes
- Get suggestions for emergency exit routes
- Build and download your pre-incident plan
- Optionally file your emergency info with emergency responders like your local fire department
- Get reminders for when you need to replace your fire extinguisher and smoke detector batteries

## Installation

[Download the Android APK file by clicking here](https://fireprepkit.s3-us-west-2.amazonaws.com/FirePrepKit.apk). Then, install it on your phone. Large phones like the Pixel 3 XL are recommended for best viewing, as this is a pre-alpha build.

## Contributing

FirePrepKitUI is an open source project under a left copright license. Contributions are welcome!

### Prerequisites

We are looking for people with the following skills:

- Unity3D UI
- Unity3D AR
- C#

### Developer Installation

1. Fork this project on GitHub. Before you do anything else, login/signup on GitHub and fork `FirePrepKitMobile` from the [GitHub project](https://github.com/worldimprovementlab/FirePrepKitMobile).

2. Clone your fork locally. If you have git-scm installed, you now clone your git repo using the following command-line argument where <my-github-name> is your account name on GitHub:

```bash
git clone git@github.com:<my-github-name>/FirePrepKitMobile.git
cd FirePrepKitMobile
```

3. [Download and install Unity](https://unity3d.com/get-unity/download).

4. Using Unity Hub, add `FirePrepKitMobile`.

### Read the Issues

The list of outstanding FirePrepKitMobile feature requests and bugs can be found on our [GitHub issue tracker](https://github.com/worldimprovementlab/FirePrepKitMobile/issues). Pick an unassigned issue that you think you can accomplish, add a comment that you are attempting to do it, and shortly your own personal label matching your GitHub ID will be assigned to that issue.

Feel free to propose issues that aren’t described!

### Setting up topic branches and generating pull requests

While it’s handy to provide useful code snippets in an issue, it is better for you as a developer to submit pull requests. By submitting pull request your contribution to FirePrepKitMobile will be recorded by Github.

In git it is best to isolate each topic or feature into a “topic branch”. While individual commits allow you control over how small individual changes are made to the code, branches are a great way to group a set of commits all related to one feature together, or to isolate different efforts when you might be working on multiple topics at the same time.

While it takes some experience to get the right feel about how to break up commits, a topic branch should be limited in scope to a single issue as submitted to an issue tracker.

Also since GitHub pegs and syncs a pull request to a specific branch, it is the ONLY way that you can submit more than one fix at a time. If you submit a pull from your develop branch, you can’t make any more commits to your develop without those getting added to the pull.

To create a topic branch, its easiest to use the convenient -b argument to git checkout:

```
git checkout -b fix-broken-thing
Switched to a new branch 'fix-broken-thing'
```

You should use a verbose enough name for your branch so it is clear what it is about. Now you can commit your changes and regularly merge in the upstream develop as described below.

When you are ready to generate a pull request, either for preliminary review, or for consideration of merging into the project you must first push your local topic branch back up to GitHub:

```
git push origin fix-broken-thing
```

Now when you go to your fork on GitHub, you will see this branch listed under the “Source” tab where it says “Switch Branches”. Go ahead and select your topic branch from this list, and then click the “Pull request” button.

Here you can add a comment about your branch. If this in response to a submitted issue, it is good to put a link to that issue in this initial comment. The repo managers will be notified of your pull request and it will be reviewed (see below for best practices). Note that you can continue to add commits to your topic branch (and push them up to GitHub) either if you see something that needs changing, or in response to a reviewer’s comments. If a reviewer asks for changes, you do not need to close the pull and reissue it after making changes. Just make the changes locally, push them to GitHub, then add a comment to the discussion section of the pull request.

### Pull upstream changes into your fork regularly

Django Packages is advancing quickly. It is therefore critical that you pull upstream changes from develop into your fork on a regular basis. Nothing is worse than putting in a days of hard work into a pull request only to have it rejected because it has diverged too far from develop.

To pull in upstream changes:

```
git remote add upstream https://github.com/worldimprovementlab/FirePrepKitMobile.git
git fetch upstream develop
```

Check the log to be sure that you actually want the changes, before merging:

```
git log upstream/develop
```

Then merge the changes that you fetched:

```
git merge upstream/develop
```

For more info, see http://help.github.com/fork-a-repo/

### How to get your pull request accepte

We want your submission. But we also want to provide a stable experience for our users and the community. Follow these rules and you should succeed without a problem!

#### Run the tests!

TODO Need to add tests and how to run them

#### If you add code/views you need to add tests!

We’ve learned the hard way that code without tests is undependable. If your pull request reduces our test coverage because it lacks tests then it will be rejected.

Keep your tests as simple as possible. Complex tests end up requiring their own tests. We would rather see duplicated assertions across test methods then cunning utility methods that magically determine which assertions are needed at a particular stage. Remember: Explicit is better than implicit.

#### Don’t mix code changes with whitespace cleanup

If you change two lines of code and correct 200 lines of whitespace issues in a file the diff on that pull request is functionally unreadable and will be rejected. Whitespace cleanups need to be in their own pull request.

#### Keep your pull requests limited to a single issue

Pull requests should be as small/atomic as possible. Large, wide-sweeping changes in a pull request will be rejected, with comments to isolate the specific code in your pull request.

#### Follow C# coding standards and keep your code simple!

Please keep your code as clean and straightforward as possible.

---

## Old Installation Instructions

- Install Unity 2019.2.12f1
- Git clone the project
- Open the project in Unity
- Connect an Android phone with a large screen (we used a Pixel 3 XL) to your computer via USB
- Open File > Build Settings
- Choose Platform: Android
- Next to Run Device, click Refresh. Wait for it to detect your phone, then choose it from the dropdown.
- Click the Build and Run button.
- Save the build as FilePrepKitAndroidUnityBuild.apk
- Wait a moment for it to run on your Android device. The screen will go blank, then wait patiently for the app to start.
