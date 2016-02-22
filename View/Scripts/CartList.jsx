
var List = React.createClass({
    render: function () {
        return (
                <table class="table">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Price</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id="userList">
                    <UsersList data="{this.props.data}" />
                </tbody>
                </table>
      );
    }
});

var UsersList = React.createClass({
    render: function () {
        var users = this.props.data.map(function (user) {
            return (
              <Comment author={user.login}>
                  {comment.Text}
              </Comment>
          );
        });
        return (
            {
                users
            }
    );
    }
});

var User = React.createClass({
    render: function () {
        var user = this.props.data;
        return (
                <tr class="product">
                        <td>user.login</td>
                        <td>user.price</td>
                        <td><button class="btn btn-danger pull-right">Remove</button></td>
                </tr>
      );
    }
});


function loadList(data)
{
       ReactDOM.render(
          <List data={data} />,
            document.getElementById('container')
      );
}

function addItemToList(user)
{
    ReactDOM.render(
          <List data={user} />,
        document.getElementById('userList')
      );
}

